using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public string arabicTitle { get; set; } = string.Empty;
        public string englishTitle { get; set; } = string.Empty;
        public bool updateOnArabicFile {  get; set; }
        public IFormFile? arabicFile { get; set; }
        public bool updateOnEnglishFile {  get; set; }
        public IFormFile? englishFile { get; set; }
        public string? lang { get; set; }
    }
}
