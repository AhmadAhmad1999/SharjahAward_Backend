using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions
{
    public class UpdateEducationalInstitutionsHandler : IRequestHandler<UpdateEducationalInstitutionsCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        public UpdateEducationalInstitutionsHandler(IMapper Mapper,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository)
        {
            _Mapper = Mapper;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateEducationalInstitutionsCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalInstitution? EducationalInstitutionEntityToUpdate = await _EducationalInstitutionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalInstitutionEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational institution is not found"
                    : "المؤسسة التعليمية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, EducationalInstitutionEntityToUpdate, typeof(UpdateEducationalInstitutionsCommand), typeof(EducationalInstitution));

            await _EducationalInstitutionRepository.UpdateAsync(EducationalInstitutionEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Educational institution has been updated successfully"
                : "تم تعديل المؤسسة التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}