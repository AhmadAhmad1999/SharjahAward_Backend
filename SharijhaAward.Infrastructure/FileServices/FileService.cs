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
using Microsoft.Extensions.Hosting;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using EnumsNET;
using System.Net.Http;

namespace SharijhaAward.Infrastructure.FileServices
{
    public class FileService : IFileService
    {

        private readonly string _SavePath;
        private readonly string _SaveProvidedFormPath;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly HttpClient _HttpClient;

        public FileService( IWebHostEnvironment environment, IHttpContextAccessor httpContextAccessor,
            HttpClient _HttpClient)
        {
            this._HttpClient = _HttpClient;
            _SavePath = Path.Combine(environment.ContentRootPath + "/wwwroot", "UploadedFiles");

            _SaveProvidedFormPath = Path.Combine(environment.ContentRootPath + "/wwwroot", "ProvidedForm");
            
            if (!Directory.Exists(_SavePath))
            {
                Directory.CreateDirectory(_SavePath);
            }

            if (!Directory.Exists(_SaveProvidedFormPath))
            {
                Directory.CreateDirectory(_SaveProvidedFormPath);
            }
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> SaveProvidedFormFilesAsync(IFormFile file, int formId)
        {
            string path = _SaveProvidedFormPath + "/"+$"{formId}";
           
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var filePath = Path.Combine(path, Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return filePath;
        }
        // Done
        public async Task<string> SaveFileAsync(IFormFile file, SystemFileType fileType)
        {
            
            string path = _SavePath + "/" + $"{fileType.GetName()}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var filePath = Path.Combine(path, Guid.NewGuid().ToString() + Path.GetExtension(file.FileName));

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            
            return filePath;
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

        public async Task<byte[]> ReadFileAsync(string filePath, SystemFileType fileType)
        {
            /* _SavePath + '/' + fileType.GetName() + '/' + filePath.Split('/').LastOrDefault();*/

            bool isHttps = _httpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_httpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_httpContextAccessor.HttpContext?.Request.Host.Value}";

            string path = (WWWRootFilePath + (filePath.Contains("wwwroot")
                ? filePath.Split("wwwroot")[1]
                : filePath)).Replace("\\", "/");

            var response2 = await _HttpClient.GetAsync(path);
            response2.EnsureSuccessStatusCode();

            return await response2.Content.ReadAsByteArrayAsync();
        }
    }
}
