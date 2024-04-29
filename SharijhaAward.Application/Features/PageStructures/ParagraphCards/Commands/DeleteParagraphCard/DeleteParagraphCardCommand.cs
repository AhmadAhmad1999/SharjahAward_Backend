using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.DeleteParagraphCard
{
    public class DeleteParagraphCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public string? lang {  get; set; }
    }
}
