using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Command.DeleteCategory
{
    public class DeleteCategoryCommand : IRequest<BaseResponse<object>>
    {
        public Guid CategoryId {  get; set; }
        public string lang {  get; set; } = string.Empty;
    }
}
