using AIO.IDOS3.Client.Mobile.DependencyServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AIO.IDOS3.Client.Mobile.Utilities
{

    public sealed class CommonUtility
    {

        #region Methods

        public static async Task<string> PerformTakePhoto(string directory, string fileName)
        {
            string filePath = null;

            var mediaOptions = new MediaPickerOptions();
            //mediaOptions.Title = "Customer Photo";

            GC.Collect();
            var file = await MediaPicker.CapturePhotoAsync(mediaOptions);
            if (file != null)
            {
                await DependencyService.Resolve<IImageProcessingService>().Process(file.FullPath, 30, 720);

                using (var stream = await file.OpenReadAsync())
                {
                    var directoryPath = Path.Combine(DependencyService.Resolve<IFileService>().GetPicturesDirectory(), directory);
                    if (!Directory.Exists(directoryPath))
                        Directory.CreateDirectory(directoryPath);

                    fileName = fileName + Path.GetExtension(file.FileName);
                    filePath = Path.Combine(directoryPath, fileName);

                    using (var newStream = File.OpenWrite(filePath))
                    {
                        await stream.CopyToAsync(newStream);

                        newStream.Close();
                        await newStream.DisposeAsync();
                    }

                    stream.Close();
                    await stream.DisposeAsync();
                }

                GC.Collect();
            }

            return filePath;
        }


        public static string GetDownloadFileUrl(string pathName, string fileName)
        {
            return GetDownloadFileUrl(pathName, fileName, false);
        }

        public static string GetDownloadFileUrl(string pathName, string fileName, bool thumbnail)
        {
            var uri = new Uri(string.Format(App.DownloadFileServiceMethod + "?fileName={0}&pathName={1}&thumbnail={2}", fileName, pathName, thumbnail));

            return uri.AbsoluteUri;
        }


        public static async Task DownloadFile(string pathName, string fileName)
        {
            var cts = new CancellationTokenSource();

            await DownloadFile(pathName, fileName, null, cts.Token);

            cts.Dispose();
        }

        public static async Task DownloadFile(string pathName, string fileName, IProgress<double> progress, CancellationToken token)
        {
            await DownloadFile(GetDownloadFileUrl(pathName, fileName), progress, token);
        }

        public static async Task DownloadFile(string url, IProgress<double> progress, CancellationToken token, int bufferSize = 4095)
        {
            var storageWriteStatus = await Permissions.RequestAsync<Permissions.StorageWrite>();

            if ((storageWriteStatus == PermissionStatus.Granted) && ValidateInternetConnection())
            {
                var httpClient = new HttpClient();

                var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, token);

                if (!response.IsSuccessStatusCode)
                    throw new Exception(string.Format("The request returned with HTTP status code {0}", response.StatusCode));

                var fileName = (response.Content.Headers?.ContentDisposition?.FileName) ?? "tmp.zip";

                var totalData = response.Content.Headers.ContentLength.GetValueOrDefault(-1);
                var filePath = Path.Combine(DependencyService.Resolve<IFileService>().GetPublicDownloadsDirectory(), fileName);

                if (File.Exists(filePath))
                    File.Delete(filePath);

                using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize))
                {
                    using (var stream = await response.Content.ReadAsStreamAsync())
                    {
                        var totalRead = 0;
                        var buffer = new byte[bufferSize];
                        var isReading = true;

                        while (isReading)
                        {
                            token.ThrowIfCancellationRequested();

                            var read = await stream.ReadAsync(buffer, 0, buffer.Length, token);
                            if (read == 0)
                            {
                                isReading = false;

                                if (progress != null)
                                    progress.Report(1d);
                            }
                            else
                            {
                                await fileStream.WriteAsync(buffer, 0, read);

                                totalRead += read;
                                if (progress != null)
                                    progress.Report((double)totalRead / totalData);
                            }
                        }

                        stream.Close();
                        await stream.DisposeAsync();
                    }

                    fileStream.Close();
                    await fileStream.DisposeAsync();
                }
            }
        }


        public static async Task<HttpResponseMessage> UploadFile(string filePath, string targetPathName, string targetFileName)
        {
            return await UploadFile(filePath, targetPathName, targetFileName, false);
        }

        public static async Task<HttpResponseMessage> UploadFile(string filePath, string targetPathName, string targetFileName, bool createThumbnail)
        {
            var storageWriteStatus = await Permissions.RequestAsync<Permissions.StorageWrite>();

            if ((storageWriteStatus == PermissionStatus.Granted) && ValidateInternetConnection())
            {
                var content = new MultipartFormDataContent();

                content.Add(new StreamContent(File.OpenRead(filePath)), targetFileName, targetFileName);

                HttpResponseMessage httpResponseMessage = null;
                using (var httpClient = new HttpClient())
                {
                    var uri = new Uri(string.Format(App.UploadFileServiceMethod + "?fileName={0}&pathName={1}&createThumbnail={2}", targetFileName, targetPathName, createThumbnail));
                    httpResponseMessage = await httpClient.PostAsync(uri, content);
                    if (!httpResponseMessage.IsSuccessStatusCode)
                        throw new Exception("Upload Error."); ////////////////////////////////////////////////////////
                }

                return httpResponseMessage;
            }

            await Task.CompletedTask;

            return null;
        }

        public static async Task<HttpResponseMessage> UploadFiles(List<string> filePaths, List<string> targetPathNames, List<string> targetFileNames)
        {
            return await UploadFiles(filePaths, targetPathNames, targetFileNames, false);
        }

        public static async Task<HttpResponseMessage> UploadFiles(List<string> filePaths, List<string> targetPathNames, List<string> targetFileNames, bool createThumbnail)
        {
            var storageWriteStatus = await Permissions.RequestAsync<Permissions.StorageWrite>();

            if ((storageWriteStatus == PermissionStatus.Granted) && ValidateInternetConnection())
            {
                var content = new MultipartFormDataContent();

                var targetFileName = "";
                var targetPathName = "";
                for (var i = 0; i < filePaths.Count; i++)
                {
                    if (i > 0)
                    {
                        targetFileName += "|";
                        targetPathName += "|";
                    }

                    targetFileName += targetFileNames[i];
                    targetPathName += targetPathNames[i];

                    content.Add(new StreamContent(File.OpenRead(filePaths[i])), targetFileNames[i], targetFileNames[i]);
                }

                HttpResponseMessage httpResponseMessage = null;
                using (var httpClient = new HttpClient())
                {
                    var uri = new Uri(string.Format(App.UploadFileServiceMethod + "?fileName={0}&pathName={1}&createThumbnail={2}", targetFileName, targetPathName, createThumbnail));

                    httpResponseMessage = await httpClient.PostAsync(uri, content);
                    if (!httpResponseMessage.IsSuccessStatusCode)
                        throw new Exception("Upload Error."); ////////////////////////////////////////////////////////
                }

                return httpResponseMessage;
            }

            await Task.CompletedTask;

            return null;
        }


        public static async Task<Location> GetLocation()
        {
            var cts = new CancellationTokenSource();
            var location = await GetLocation(cts.Token);

            cts.Dispose();

            return location;
        }

        public static async Task<Location> GetLocation(CancellationToken token)
        {
            var locationAlwaysStatus = PermissionStatus.Unknown;
            var locationWhenInUseStatus = PermissionStatus.Unknown;

            await Device.InvokeOnMainThreadAsync(async () =>
            {
                locationAlwaysStatus = await Permissions.RequestAsync<Permissions.LocationAlways>();
                locationWhenInUseStatus = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            });

            if ((locationAlwaysStatus == PermissionStatus.Granted) || (locationWhenInUseStatus == PermissionStatus.Granted))
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Default, TimeSpan.FromSeconds(10));
                var location = await Geolocation.GetLocationAsync(request, token);

                if (location != null)
                    return location;
            }

            throw new NullReferenceException("Location can not be retrieved. Please check your Location Permission Settings.");
        }


        public static string GenerateNameInitials(string name)
        {
            // first remove all: punctuation, separator chars, control chars, and numbers (unicode style regexes)
            string initials = Regex.Replace(name, @"[\p{P}\p{S}\p{C}\p{N}]+", "");

            // Replacing all possible whitespace/separator characters (unicode style), with a single, regular ascii space.
            initials = Regex.Replace(initials, @"\p{Z}+", " ");

            // Remove all Sr, Jr, I, II, III, IV, V, VI, VII, VIII, IX at the end of names
            initials = Regex.Replace(initials.Trim(), @"\s+(?:[JS]R|I{1,3}|I[VX]|VI{0,3})$", "", RegexOptions.IgnoreCase);

            // Extract up to 2 initials from the remaining cleaned name.
            initials = Regex.Replace(initials, @"^(\p{L})[^\s]*(?:\s+(?:\p{L}+\s+(?=\p{L}))?(?:(\p{L})\p{L}*)?)?$", "$1$2").Trim();

            if (initials.Length > 2)
                initials = initials.Substring(0, 2); // Worst case scenario, everything failed, just grab the first two letters of what we have left.

            return initials.ToUpperInvariant();
        }

        public static Color GetRandomColor()
        {
            var colorNumber = new Random().Next(10);

            switch (colorNumber)
            {
                case 1: return Color.FromHex("#f15558");
                case 2: return Color.FromHex("#ff7c11");
                case 3: return Color.FromHex("#ffbf22");
                case 4: return Color.FromHex("#ff6e86");
                case 5: return Color.FromHex("#9865b0");
                case 6: return Color.FromHex("#756cfd");
                case 7: return Color.FromHex("#0055d8");
                case 8: return Color.FromHex("#01b0ee");
                case 9: return Color.FromHex("#0097ad");
                case 0: return Color.FromHex("#00c831");
                default: return Color.FromHex("#949494");
            }
        }


        public static bool ValidateInternetConnection()
        {
            switch (Connectivity.NetworkAccess)
            {
                case NetworkAccess.ConstrainedInternet:
                case NetworkAccess.Internet:
                    return true;
                default:
                    throw new OperationCanceledException("Internet connection is not available.");
            }
        }

        public static Exception InnermostException(Exception ex)
        {
            return (ex.InnerException == null) ? ex : InnermostException(ex.InnerException);
        }

        #endregion

    }

}
