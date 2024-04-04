using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorClass
{
    public class CreateArbitratorClassHandler : IRequestHandler<CreateArbitratorClassCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;

        public CreateArbitratorClassHandler(IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
             IAsyncRepository<Arbitrator> ArbitratorRepository,
             IAsyncRepository<EducationalClass> EducationalClassRepository)
        {
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _EducationalClassRepository = EducationalClassRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateArbitratorClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? CheckIfArbitratorIdIsExist = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitratorId);

            if (CheckIfArbitratorIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            EducationalClass? CheckIfEducationalClassIdIsExist = await _EducationalClassRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationalClassId);

            if (CheckIfEducationalClassIdIsExist is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Class is not found"
                    : "الصف غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 204);
            }

            ArbitratorClass? CheckIfArbitratorDoesConnectWithClass = await _ArbitratorClassRepository
                .FirstOrDefaultAsync(x => x.ArbitratorId == CheckIfArbitratorIdIsExist.Id &&
                    x.EducationalClassId == CheckIfEducationalClassIdIsExist.Id);

            if (CheckIfArbitratorDoesConnectWithClass is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This arbitrator already is already arbitrating on this class"
                    : "هذا المحكم يحكم مسبقاً على هذا الصف";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            ArbitratorClass NewArbitratorClassEntity = new ArbitratorClass()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                ArbitratorId = CheckIfArbitratorIdIsExist.Id,
                EducationalClassId = CheckIfEducationalClassIdIsExist.Id
            };

            await _ArbitratorClassRepository.AddAsync(NewArbitratorClassEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم ربط المحكم بصف جديد بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
