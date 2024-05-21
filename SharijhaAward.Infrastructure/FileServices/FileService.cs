using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MimeKit;
using SharijhaAward.Application.Contract.Infrastructure;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.AttachmentModel;
using System.Net;

namespace SharijhaAward.Infrastructure.FileServices
{
    public class FileService : IFileService
    {

        private readonly string _SavePath;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FileService( IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor)
        {

            _SavePath = Path.Combine(environment.ContentRootPath + "/wwwroot", "UploadedFiles");

            if (!Directory.Exists(_SavePath))
            {
                Directory.CreateDirectory(_SavePath);
            }
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SaveFileAsync(IFormFile file)
        {
            var filePath = Path.Combine(_SavePath, Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            bool isHttps = _httpContextAccessor.HttpContext!.Request.IsHttps;

            return isHttps
                  ? $"https://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{filePath.Split('\\').LastOrDefault()}"
                  : $"http://{_httpContextAccessor.HttpContext?.Request.Host.Value}/UploadedFiles/{filePath.Split('\\').LastOrDefault()}";
        }
        public async Task<string> SaveFileAndGetPath(IFormFile file)
        {
            var filePath = Path.Combine(_SavePath, Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
           

            return filePath;
        }

        public async Task<byte[]> ReadFileAsync(string filePath)
        {
            var path = _SavePath +'/'+ filePath.Split('/').LastOrDefault();
            return await File.ReadAllBytesAsync(path);
        }

    }
}
