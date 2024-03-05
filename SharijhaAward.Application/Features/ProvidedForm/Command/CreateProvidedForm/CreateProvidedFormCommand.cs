using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm
{
    public class CreateProvidedFormCommand : IRequest<BaseResponse<int>>
    {
        public Guid categoryId {  get; set; }
        public string lang {  get; set; } =string.Empty;
        public string token {  get; set; } = string.Empty;
    }
}
