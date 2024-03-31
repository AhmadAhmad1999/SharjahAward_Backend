using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Commands.DeleteClass
{
    public class DeleteClassHandler : IRequestHandler<DeleteClassCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        public DeleteClassHandler(IAsyncRepository<EducationalClass> EducationalClassRepository)
        {
            _EducationalClassRepository = EducationalClassRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalClass? EducationalClassEntityToDelete = await _EducationalClassRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalClassEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Class is not found"
                    : "الصف غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EducationalClassRepository.DeleteAsync(EducationalClassEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Class has been deleted successfully"
                : "تم حذف الصف بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
