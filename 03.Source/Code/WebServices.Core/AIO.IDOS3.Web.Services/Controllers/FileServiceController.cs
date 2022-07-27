using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Threading.Tasks;

namespace AIO.IDOS3.Web.Services.Controllers
{

    [Route("FileServices")]
    [ApiController]
    public class FileServiceController : Controller
    {

        #region Fields

        protected readonly ILogger<FileServiceController> logger;
        protected readonly AppSettings appSettings;

        #endregion

        #region Constructors

        public FileServiceController(ILogger<FileServiceController> logger, IOptions<AppSettings> appSettingsOptions)
        {
            this.logger = logger;
            this.appSettings = appSettingsOptions.Value;
        }

        #endregion

        #region Methods

        [HttpGet("Download")]
        public async Task<IActionResult> Download([FromQuery] string fileName, [FromQuery] string pathName, [FromQuery] bool thumbnail)
        {
            await Task.CompletedTask;

            try
            {
                if (thumbnail)
                    fileName = string.Format("t_{0}", fileName);
                
                if (string.IsNullOrEmpty(fileName))
                    return BadRequest();

                var folderDirectory = Path.Combine(appSettings.FilesDirectory, pathName);
                var filePath = Path.Combine(folderDirectory, fileName);

                var fileInfo = new FileInfo(filePath);
                if (fileInfo.Exists)
                {
                    var file = System.IO.File.OpenRead(filePath);
                    var contentDisposition = new ContentDisposition { FileName = fileName, Inline = false };

                    Response.Headers.Add("Content-Disposition", contentDisposition.ToString());

                    return File(file, "application/octet-stream");
                }
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost("Upload"), DisableRequestSizeLimit]
        public async Task<IActionResult> Upload([FromQuery] string fileName, [FromQuery] string pathName, [FromQuery] bool createThumbnail)
        {
            try
            {
                if (string.IsNullOrEmpty(fileName))
                    return BadRequest();

                var fileNames = fileName.Split('|', StringSplitOptions.RemoveEmptyEntries);
                var pathNames = pathName.Split('|', StringSplitOptions.RemoveEmptyEntries);

                if (Request.Form.Files.Count > 0)
                {
                    var webFilePaths = "";

                    for (var i = 0; i < Request.Form.Files.Count; i++)
                    {
                        var file = Request.Form.Files[i];
                        var folderDirectory = Path.Combine(appSettings.FilesDirectory, pathNames[i]);

                        if (file.Length > 0)
                        {
                            Directory.CreateDirectory(folderDirectory);

                            var filePath = Path.Combine(folderDirectory, fileNames[i]);
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                await file.CopyToAsync(stream);
                            }

                            if (createThumbnail)
                            {
                                var thumbFilePath = Path.Combine(folderDirectory, string.Format("t_{0}", fileNames[i]));
                                //CreateThumbnailImage(appSettings.ThumbnailMaxSize, appSettings.ThumbnailMaxSize, filePath, thumbFilePath);

                                /////////////////////////////////////////////////////////////////////////////////////
                                using (var stream = new FileStream(thumbFilePath, FileMode.Create))
                                {
                                    await file.CopyToAsync(stream);
                                }
                            }

                            if (!string.IsNullOrEmpty(webFilePaths))
                                webFilePaths += '|';

                            webFilePaths += Path.Combine(pathNames[i], fileNames[i]);
                        }
                    }

                    return Ok(new { webFilePaths });
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }



        private void CreateThumbnailImage(int maxWidth, int maxHeight, string originalFilePath, string thumbFilePath)
        {
            try
            {
                using (var image = Image.FromFile(originalFilePath))
                {
                    var ratioX = (double)maxWidth / image.Width;
                    var ratioY = (double)maxHeight / image.Height;
                    var ratio = Math.Min(ratioX, ratioY);

                    var thumbWidth = (int)(image.Width * ratio);
                    var thumbHeight = (int)(image.Height * ratio);

                    var thumbImage = new Bitmap(thumbWidth, thumbHeight);
                    var thumbGraph = Graphics.FromImage(thumbImage);

                    thumbGraph.CompositingQuality = CompositingQuality.HighSpeed;
                    thumbGraph.SmoothingMode = SmoothingMode.HighSpeed;
                    thumbGraph.InterpolationMode = InterpolationMode.Low;
                    thumbGraph.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                    thumbGraph.DrawImage(image, 0, 0, thumbWidth, thumbHeight);                    
                    thumbImage.Save(thumbFilePath, thumbImage.RawFormat);
                }
            }
            catch { }
        }

        #endregion

    }

}
