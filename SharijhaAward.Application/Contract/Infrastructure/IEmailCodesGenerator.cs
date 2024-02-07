using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Infrastructure
{
    public interface IEmailCodesGenerator
    {
        public Task<string> GenerateQRCode(string? Data, string WWWRootFolderPath);
        string GenerateBarCode(string Data, string WWWRootFolderPath);
    }
}
