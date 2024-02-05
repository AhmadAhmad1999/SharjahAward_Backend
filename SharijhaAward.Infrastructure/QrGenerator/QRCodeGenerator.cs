using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net;
using SharijhaAward.Application.Contract.Infrastructure;

namespace SharijhaAward.Infrastructure.QRGenerator
{
    public class QRCodeGenerator : IQRCodeGenerator
    {
        private IConfiguration _Configuration;
        public QRCodeGenerator(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        /* 
         * This Data Paramater Must Contain (Guid For [Personal, Group Invite] + Type Of Invitation + Event Name) Sepereated With '/'
        */
        public async Task<string> GenerateQRCode(string Data, string WWWRootFolderPath)
        {
            Uri? URI = new Uri($"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={Data}");
            HttpWebRequest Request = WebRequest.CreateHttp(URI);
            WebResponse? Response = await Request.GetResponseAsync();
            ContentDispositionHeaderValue ContentDisposition;
            string FilePath = WWWRootFolderPath + "/Images";

            string[] DataSpliter = Data.Split('/');

            string? FileName = ContentDispositionHeaderValue.TryParse(Response.Headers["Content-Disposition"], out ContentDisposition)
                ? ContentDisposition.FileName
                : $"QRCodeFor-{DataSpliter[2]}-{DataSpliter[1]}-{DataSpliter[0]}-Invite.png";

            using (FileStream? FileStream = new FileStream(FilePath + "/" + FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await Response.GetResponseStream().CopyToAsync(FileStream);
            }

            return FilePath + "/" + FileName;
        }
    }
}