using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicLabel { get; set; } = null!;
        public string EnglishLabel { get; set; } = null!;
        public string ArabicPlaceHolder { get; set; } = null!;
        public string EnglishPlaceHolder { get; set; } = null!;
        public bool IsRequired { get; set; }
        public List<string>? Values { get; set; }
        public int? MaxSizeInKB { get; set; }
        public string? lang { get; set; }
    }
}
