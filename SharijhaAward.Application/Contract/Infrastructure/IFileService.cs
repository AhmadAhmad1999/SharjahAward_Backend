using Microsoft.AspNetCore.Http;
using MimeKit;
using SharijhaAward.Domain.Constants.AttachmentConstant;
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
        Task<string> SaveFileAsync(IFormFile file, SystemFileType fileType);
        Task<string> SaveFileAndGetPath(IFormFile file);
        Task<string> SaveProvidedFormFilesAsync(IFormFile file, int formId);
        Task<byte[]> ReadFileAsync(string filePath, SystemFileType fileType);
    }
}
