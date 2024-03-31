using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Command.UpdateEducationalEntity
{
    public class UpdateEducationalEntityHandler : IRequestHandler<UpdateEducationalEntityCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public UpdateEducationalEntityHandler(IMapper Mapper,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _EducationalEntityRepository = EducationalEntityRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateEducationalEntityCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntityToUpdate = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity is not found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, EducationalEntityToUpdate, typeof(UpdateEducationalEntityCommand), typeof(EducationalEntity));

            await _EducationalEntityRepository.UpdateAsync(EducationalEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Educational entity has been updated successfully"
                : "تم تعديل الجهة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
