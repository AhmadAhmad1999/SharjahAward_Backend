using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Commands.CreateIndex
{
    public class CreateIndexCommand : IRequest<BaseResponse<object>>
    {
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicName { get; set; } = string.Empty;
        public string? Slug { get; set; } = string.Empty;
        public string? lang {  get; set; } = string.Empty;
    }
}
