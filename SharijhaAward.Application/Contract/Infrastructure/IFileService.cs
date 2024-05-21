using Microsoft.AspNetCore.Http;
using MimeKit;
using SharijhaAward.Domain.Entities.AttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Infrastructure
{
    public interface IFileService
    {
        Task<string> SaveFileAsync(IFormFile file);
        Task<string> SaveFileAndGetPath(IFormFile file);
        Task<byte[]> ReadFileAsync(string filePath);
    }
}
