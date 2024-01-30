﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using SharijhaAward.Domain.Entities.InvitationModels;
using SharijhaAward.Application.Models;

namespace SharijhaAward.Application.Contract.Infrastructure
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
        public async Task<string> GenerateQRCode(string Data)
        {
            Uri? URI = new Uri($"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={Data}");
            HttpWebRequest Request = WebRequest.CreateHttp(URI);
            WebResponse? Response = await Request.GetResponseAsync();
            ContentDispositionHeaderValue ContentDisposition;
            string FilePath = "wwwroot/Images";

            string[] DataSpliter = Data.Split('/');

            string? FileName = ContentDispositionHeaderValue.TryParse(Response.Headers["Content-Disposition"], out ContentDisposition)
                ? ContentDisposition.FileName
                : $"QRCodeFor{DataSpliter[2]}{DataSpliter[1]}Invite.png";

            using (FileStream? FileStream = new FileStream(FilePath + "/" + FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await Response.GetResponseStream().CopyToAsync(FileStream);
            }

            return  FilePath + "/" + FileName;
        }
    }
}
//E:\WarshaTec\SharijhaAward\SharijhaAward\SharijhaAward.Api\QREmailHelper\assets\qr\QRCodeForstringPersonalInvite.png