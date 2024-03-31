using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Application.Features.Classes.Commands.UpdateClass
{
    public class UpdateClassHandler : IRequestHandler<UpdateClassCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IMapper _Mapper;

        public UpdateClassHandler(IMapper Mapper,
            IAsyncRepository<EducationalClass> EducationalClassRepository)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateClassCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalClass? EducationalClassEntityToUpdate = await _EducationalClassRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalClassEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Class is not found"
                    : "الصف غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, EducationalClassEntityToUpdate, typeof(UpdateClassCommand), typeof(EducationalClass));

            await _EducationalClassRepository.UpdateAsync(EducationalClassEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Class has been updated successfully"
                : "تم تعديل الصف بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}