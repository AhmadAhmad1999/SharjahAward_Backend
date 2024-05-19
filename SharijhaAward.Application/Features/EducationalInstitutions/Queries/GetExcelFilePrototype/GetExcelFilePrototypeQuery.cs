using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetExcelFilePrototype
{
    public class GetExcelFilePrototypeQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
