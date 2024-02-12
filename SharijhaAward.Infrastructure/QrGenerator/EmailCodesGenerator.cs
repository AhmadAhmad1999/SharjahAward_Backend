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
            BarcodeSettings BarCodeSettings = new BarcodeSettings();

            BarCodeSettings.Type = BarCodeType.Code39;
            BarCodeSettings.Data = Data;
            BarCodeGenerator BarCodeGenerator = new BarCodeGenerator(BarCodeSettings);

            string Path = System.IO.Path.Combine(WWWRootFolderPath, "GeneratedBarcode");
            if (!Directory.Exists(Path))
                Directory.CreateDirectory(Path);

            string FilePath = System.IO.Path.Combine(Path,
                $"BarCodeFor-{Data}-Invite.png");

            Image barcodeImage = BarCodeGenerator.GenerateImage();
            Bitmap croppedImage = new Bitmap(barcodeImage.Width, barcodeImage.Height - 50);

            using (Graphics graphics = Graphics.FromImage(croppedImage))
            {
                graphics.DrawImage(barcodeImage, 0, 0, new Rectangle(0, 50, barcodeImage.Width, barcodeImage.Height - 50), GraphicsUnit.Pixel);
            }

            croppedImage.Save(FilePath);
            return FilePath;
        }
    }
}