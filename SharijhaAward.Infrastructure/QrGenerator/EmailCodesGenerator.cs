using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Net;
using SharijhaAward.Application.Contract.Infrastructure;
using IronBarCode;
using Microsoft.AspNetCore.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using QRCoder;
using Spire.Barcode;
using BarcodeLib;

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
            WebResponse? Response;
            try
            {
                Response = await Request.GetResponseAsync();
            }
            catch (WebException)
            {
                throw;
            }
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
            Barcode Barcode = new Barcode();
            Image BarCodeImage = Barcode.Encode(TYPE.CODE39, Data, Color.Black, Color.White, 500, 100);

            string Path = System.IO.Path.Combine(WWWRootFolderPath, "GeneratedBarcode");
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            string FilePath = System.IO.Path.Combine(Path,
                $"BarCodeFor-{Data}-Invite.png");

            Bitmap CroppedImage = new Bitmap(BarCodeImage.Width, BarCodeImage.Height);

            using (Graphics Graphics = Graphics.FromImage(CroppedImage))
            {
                Graphics.DrawImage(BarCodeImage, 0, 0, new Rectangle(0, 50, BarCodeImage.Width, BarCodeImage.Height), GraphicsUnit.Pixel);
            }

            CroppedImage.Save(FilePath);
            return FilePath;
        }
    }
}