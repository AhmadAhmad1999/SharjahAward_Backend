using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype
{
    public class GetExcelFilePrototypeQueryHandler
        : IRequestHandler<GetExcelFilePrototypeQuery, BaseResponse<byte[]>>
    {
        private readonly IExcelHelper<EducationalEntityExcelDto> _excelHelper;

        public GetExcelFilePrototypeQueryHandler(IExcelHelper<EducationalEntityExcelDto> excelHelper)
        {
            _excelHelper = excelHelper;
        }
        public async Task<BaseResponse<byte[]>> Handle(GetExcelFilePrototypeQuery request, CancellationToken cancellationToken)
        {
            var file = _excelHelper.GeneratePrototype();

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
