using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsWithArbitrators
{
    public class GetFormsWithArbitratorsQuery : IRequest<BaseResponse<List<FormsWithArbitratorsDto>>>
    {
        public int? CycleId {  get; set; }
        
    }
}
