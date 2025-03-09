using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype
{
    public class GetExcelFilePrototypeQuery : IRequest<BaseResponse<byte[]>>
    {
    }
}
