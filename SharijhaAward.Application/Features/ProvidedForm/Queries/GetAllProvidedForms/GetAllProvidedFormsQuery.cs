using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class GetAllProvidedFormsQuery : IRequest<BaseResponse<List<FormListVm>>>
    {
        public ProvidedFormType? Type { get; set; }
        public string token { get; set; } = string.Empty;
    }
}
