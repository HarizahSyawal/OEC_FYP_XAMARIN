using AIO.IDOS3.Client.Mobile.DependencyServices;
using Android.Content;
using Android.Graphics;
using Android.Media;
using Android.OS;
using System;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Android.DependencyServices
{

    public class ImageProcessingService : IImageProcessingService
    {

        #region Constants

        protected const string PixelXDimension = "PixelXDimension";
        protected const string PixelYDimension = "PixelYDimension";

        #endregion

        #region Fields

        private static Context context;

        #endregion

        #region Methods

        public static void Init(Context context)
        {
            ImageProcessingService.context = context;
            DependencyService.Register<IImageProcessingService, ImageProcessingService>();
        }



        protected async Task<bool> FixOrientationAndResize(string filePath, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight, ExifInterface exif)
        {
            var result = false;

            try
            {
                var rotation = GetRotation(exif);
                if (!string.IsNullOrWhiteSpace(filePath) && ((rotation != 0) || (compressionQuality.HasValue && (compressionQuality.Value != 100))))
                {
                    var percent = 1.0f;
                    if (customPhotoSize.HasValue)
                        percent = customPhotoSize.Value / 100f;

                    var options = new BitmapFactory.Options();
                    options.InJustDecodeBounds = true;

                    BitmapFactory.DecodeFile(filePath, options);

                    if (maxWidthHeight.HasValue)
                    {
                        var max = Math.Max(options.OutWidth, options.OutHeight);
                        if (max > maxWidthHeight.Value)
                            percent = (float)maxWidthHeight.Value / max;
                    }

                    var finalWidth = (int)(options.OutWidth * percent);
                    var finalHeight = (int)(options.OutHeight * percent);

                    options.InSampleSize = CalculateInSampleSize(options, finalWidth, finalHeight);
                    options.InJustDecodeBounds = false;

                    var originalImage = BitmapFactory.DecodeFile(filePath, options);
                    if (originalImage != null)
                    {

                        if ((finalWidth != originalImage.Width) || (finalHeight != originalImage.Height))
                            originalImage = Bitmap.CreateScaledBitmap(originalImage, finalWidth, finalHeight, true);

                        if ((rotation % 180) == 90)
                        {
                            var temp = finalWidth;
                            finalWidth = finalHeight;
                            finalHeight = temp;
                        }

                        exif?.SetAttribute(PixelXDimension, Java.Lang.Integer.ToString(finalWidth));
                        exif?.SetAttribute(PixelYDimension, Java.Lang.Integer.ToString(finalHeight));

                        var photoType = System.IO.Path.GetExtension(filePath)?.ToLower();
                        var compressFormat = (photoType == ".png") ? Bitmap.CompressFormat.Png : Bitmap.CompressFormat.Jpeg;
                        if (rotation != 0)
                        {
                            var matrix = new Matrix();
                            matrix.PostRotate(rotation);

                            using (var rotatedImage = Bitmap.CreateBitmap(originalImage, 0, 0, originalImage.Width, originalImage.Height, matrix, true))
                            {
                                using (var stream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite))
                                {
                                    rotatedImage.Compress(compressFormat, compressionQuality.Value, stream);
                                    stream.Close();
                                }

                                rotatedImage.Recycle();
                            }

                            exif?.SetAttribute(ExifInterface.TagOrientation, Java.Lang.Integer.ToString((int)Orientation.Normal));
                        }
                        else
                        {
                            using (var stream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite))
                            {
                                originalImage.Compress(compressFormat, compressionQuality.Value, stream);
                                stream.Close();
                            }
                        }

                        originalImage.Recycle();
                        originalImage.Dispose();

                        GC.Collect();
                        result = true;
                    }
                }
            }
            catch { }

            await Task.CompletedTask;

            return result;
        }

        protected async Task<bool> Resize(string filePath, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight, ExifInterface exif)
        {
            var result = false;

            try
            {
                if (!string.IsNullOrWhiteSpace(filePath) && (compressionQuality.HasValue && (compressionQuality.Value != 100)))
                {
                    var percent = 1.0f;
                    if (customPhotoSize.HasValue)
                        percent = customPhotoSize.Value / 100f;

                    var options = new BitmapFactory.Options();
                    options.InJustDecodeBounds = true;

                    BitmapFactory.DecodeFile(filePath, options);

                    if (maxWidthHeight.HasValue)
                    {
                        var max = Math.Max(options.OutWidth, options.OutHeight);
                        if (max > maxWidthHeight.Value)
                            percent = (float)maxWidthHeight.Value / max;
                    }

                    var finalWidth = (int)(options.OutWidth * percent);
                    var finalHeight = (int)(options.OutHeight * percent);

                    exif?.SetAttribute(PixelXDimension, Java.Lang.Integer.ToString(finalWidth));
                    exif?.SetAttribute(PixelYDimension, Java.Lang.Integer.ToString(finalHeight));

                    options.InSampleSize = CalculateInSampleSize(options, finalWidth, finalHeight);
                    options.InJustDecodeBounds = false;

                    using (var originalImage = BitmapFactory.DecodeFile(filePath, options))
                    {
                        using (var stream = File.Open(filePath, FileMode.Create, FileAccess.ReadWrite))
                        {
                            originalImage.Compress(Bitmap.CompressFormat.Jpeg, compressionQuality.Value, stream);
                            stream.Close();
                        }

                        originalImage.Recycle();

                        GC.Collect();
                        result = true;
                    }
                }
            }
            catch { }

            await Task.CompletedTask;

            return result;
        }


        protected bool IsValidExif(ExifInterface exif)
        {
            if (exif == null)
                return false;

            try
            {

                if ((exif != null) && (!exif.HasThumbnail || ((exif.GetThumbnail()?.Length ?? 0) > 0)))
                    return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Unable to get thumbnail exif: " + ex);
            }

            return false;
        }

        protected int CalculateInSampleSize(BitmapFactory.Options options, int requestWidth, int requestHeight)
        {
            var width = options.OutWidth;
            var height = options.OutHeight;
            var inSampleSize = 1;

            if ((height > requestHeight) || (width > requestWidth))
            {
                var halfHeight = height / 2;
                var halfWidth = width / 2;

                while (((halfHeight / inSampleSize) >= requestHeight) && ((halfWidth / inSampleSize) >= requestWidth))
                {
                    inSampleSize *= 2;
                }
            }

            return inSampleSize;
        }

        protected int GetRotation(ExifInterface exif)
        {
            try
            {
                if (exif != null)
                {
                    var orientation = (Orientation)exif.GetAttributeInt(ExifInterface.TagOrientation, (int)Orientation.Normal);

                    switch (orientation)
                    {
                        case Orientation.Rotate90:
                            return 90;
                        case Orientation.Rotate180:
                            return 180;
                        case Orientation.Rotate270:
                            return 270;
                    }
                }
            }
            catch { }

            return 0;
        }

        protected string CoordinateToRational(double coordinate)
        {
            coordinate = coordinate > 0 ? coordinate : -coordinate;
            var degrees = (int)coordinate;
            coordinate = (coordinate % 1) * 60;
            var minutes = (int)coordinate;
            coordinate = (coordinate % 1) * 60000;
            var seconds = (int)coordinate;

            return string.Format("{0}/1,{1}/1,{2}/1000", degrees, minutes, seconds);
        }

        protected void SetMissingMetadata(ExifInterface exif, double? latitude, double? longitude)
        {
            if (exif != null)
            {
                var position = new float[6];
                if (!exif.GetLatLong(position))
                {
                    if (latitude.HasValue)
                    {
                        exif.SetAttribute(ExifInterface.TagGpsLatitude, CoordinateToRational(latitude.Value));
                        exif.SetAttribute(ExifInterface.TagGpsLatitudeRef, (latitude.Value > 0) ? "N" : "S");
                    }

                    if (longitude.HasValue)
                    {
                        exif.SetAttribute(ExifInterface.TagGpsLongitude, CoordinateToRational(longitude.Value));
                        exif.SetAttribute(ExifInterface.TagGpsLongitudeRef, (longitude.Value > 0) ? "E" : "W");
                    }
                }

                if (string.IsNullOrEmpty(exif.GetAttribute(ExifInterface.TagDatetime)))
                    exif.SetAttribute(ExifInterface.TagDatetime, DateTime.Now.ToString("yyyy:MM:dd hh:mm:ss"));

                if (string.IsNullOrEmpty(exif.GetAttribute(ExifInterface.TagMake)))
                    exif.SetAttribute(ExifInterface.TagMake, Build.Manufacturer);

                if (string.IsNullOrEmpty(exif.GetAttribute(ExifInterface.TagModel)))
                    exif.SetAttribute(ExifInterface.TagModel, Build.Model);
            }
        }

        #endregion

        #region Implements IImageUtility

        public async Task<bool> Process(string filePath, int? compressionQuality, int? maxWidthHeight)
        {
            return await Process(filePath, false, compressionQuality, null, maxWidthHeight, false, null, null);
        }

        public async Task<bool> Process(string filePath, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight)
        {
            return await Process(filePath, false, compressionQuality, customPhotoSize, maxWidthHeight, false, null, null);
        }

        public async Task<bool> Process(string filePath, bool rotateImage, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight)
        {
            return await Process(filePath, rotateImage, compressionQuality, customPhotoSize, maxWidthHeight, false, null, null);
        }

        public async Task<bool> Process(string filePath, bool rotateImage, int? compressionQuality, int? customPhotoSize, int? maxWidthHeight, bool saveMetadata, double? latitude, double? longitude)
        {
            var result = false;
            ;
            try
            {
                using (var exif = new ExifInterface(filePath))
                {
                    if (rotateImage)
                        await FixOrientationAndResize(filePath, compressionQuality, customPhotoSize, maxWidthHeight, exif);
                    else
                        await Resize(filePath, compressionQuality, customPhotoSize, maxWidthHeight, exif);

                    if (saveMetadata && IsValidExif(exif))
                    {
                        SetMissingMetadata(exif, latitude, longitude);

                        try
                        {
                            exif?.SaveAttributes();
                            result = true;
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine(string.Format("Unable to save exif: {0}", ex.Message));
                        }
                    }

                    exif?.Dispose();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Unable to check orientation: {0}", ex.Message));
            }

            return result;
        }

        #endregion

    }

}
