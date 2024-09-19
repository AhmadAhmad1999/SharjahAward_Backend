using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.DeleteEducationalEntity
{
    public class DeleteEducationalEntityHandler : IRequestHandler<DeleteEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        public DeleteEducationalEntityHandler(IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntityToDelete = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EducationalEntityRepository.DeleteAsync(EducationalEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Educational entity has been deleted successfully"
                : "تم حذف الجهة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
                
        }
    }
}
