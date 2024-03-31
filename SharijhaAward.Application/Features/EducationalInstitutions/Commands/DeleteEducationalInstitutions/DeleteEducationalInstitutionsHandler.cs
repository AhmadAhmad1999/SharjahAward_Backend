using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.DeleteEducationalInstitutions
{
    public class DeleteEducationalInstitutionsHandler : IRequestHandler<DeleteEducationalInstitutionsCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        public DeleteEducationalInstitutionsHandler(IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository)
        {
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteEducationalInstitutionsCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalInstitution? EducationalInstitutionEntityToDelete = await _EducationalInstitutionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalInstitutionEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational institution is not found"
                    : "المؤسسة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EducationalInstitutionRepository.DeleteAsync(EducationalInstitutionEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Educational institution has been deleted successfully"
                : "تم حذف المؤسسة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
