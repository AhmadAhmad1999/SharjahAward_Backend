using SharijhaAward.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Infrastructure
{
    public interface IEmailSender
    {
        public Task SendEmail(EmailRequest EmailRequest, AlternateView AlternateView);
    }
}
