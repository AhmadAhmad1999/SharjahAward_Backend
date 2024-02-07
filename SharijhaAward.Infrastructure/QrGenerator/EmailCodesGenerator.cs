using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net;
using SharijhaAward.Application.Contract.Infrastructure;
using IronBarCode;
using Microsoft.AspNetCore.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace SharijhaAward.Infrastructure.QRGenerator
{
    public class EmailCodesGenerator : IEmailCodesGenerator
    {
        private IConfiguration _Configuration;
        public EmailCodesGenerator(IConfiguration Configuration)
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
        public string GenerateBarCode(string Data, string WWWRootFolderPath)
        {
            GeneratedBarcode BarCode = BarcodeWriter.CreateBarcode(Data, BarcodeWriterEncoding.Code128);

            BarCode.ResizeTo(400, 120);
            BarCode.AddBarcodeValueTextBelowBarcode();
            BarCode.ChangeBarCodeColor(Color.Black);
            BarCode.SetMargins(10);

            string Path = System.IO.Path.Combine(WWWRootFolderPath, "GeneratedBarcode");

            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            string[] DataSpliter = Data.Split('/');

            string FilePath = System.IO.Path.Combine(Path,
                $"BarCodeFor-{DataSpliter[2]}-{DataSpliter[1]}-{DataSpliter[0]}-Invite.png");

            BarCode.SaveAsPng(FilePath);
            return FilePath;
        }
    }
}