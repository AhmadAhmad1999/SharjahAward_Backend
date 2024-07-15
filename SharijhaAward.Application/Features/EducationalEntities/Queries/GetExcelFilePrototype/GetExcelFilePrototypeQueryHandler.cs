using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype
{
    public class GetExcelFilePrototypeQueryHandler
        : IRequestHandler<GetExcelFilePrototypeQuery, BaseResponse<byte[]>>
    {
        private readonly IExcelHelper<EducationalEntity> _excelHelper;

        public GetExcelFilePrototypeQueryHandler(IExcelHelper<EducationalEntity> excelHelper)
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
