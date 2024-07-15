using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype
{
    public class GetExcelFilePrototypeQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
