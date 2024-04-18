using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorClass
{
    public class DeleteArbitratorClassHandler : IRequestHandler<DeleteArbitratorClassCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        public DeleteArbitratorClassHandler(IAsyncRepository<ArbitratorClass> ArbitratorClassRepository)
        {
            _ArbitratorClassRepository = ArbitratorClassRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitratorClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ArbitratorClass? ArbitratorClassEntityToDelete = await _ArbitratorClassRepository
                .FirstOrDefaultAsync(x => x.ArbitratorId == Request.ArbitratorId && 
                    x.EducationalClassId == Request.EducationalClassId);

            if (ArbitratorClassEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator class is not found"
                    : "صف المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ArbitratorClassRepository.DeleteAsync(ArbitratorClassEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Arbitrator class has been deleted successfully"
                : "تم حذف صف المحكم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
