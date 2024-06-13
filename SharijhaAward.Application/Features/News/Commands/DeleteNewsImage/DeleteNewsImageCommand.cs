using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Commands.DeleteNewsImage
{
    public class DeleteNewsImageCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public string? lang {  get; set; }
    }
}
