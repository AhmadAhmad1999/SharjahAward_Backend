using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionCommandHandler
        : IRequestHandler<CreateEducationalInstitutionMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IMapper _Mapper;

        public CreateEducationalInstitutionCommandHandler(IMapper Mapper,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateEducationalInstitutionMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntity = await _EducationalEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationalEntityId);
           
            if(EducationalEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity dose not Exist"
                    : "الجهة التعليمية غير موجودة";
                
                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<EducationalInstitution> NewEducationalInstitutionEntities = _Mapper.Map<List<EducationalInstitution>>
                (Request.CreateEducationalInstitutionCommand);

            foreach (EducationalInstitution NewEducationalInstitutionEntity in NewEducationalInstitutionEntities)
            {
                NewEducationalInstitutionEntity.EducationalEntityId = EducationalEntity.Id;
            }

            await _EducationalInstitutionRepository.AddRangeAsync(NewEducationalInstitutionEntities);

            ResponseMessage = Request.lang == "en"
                ? "Created Successfuly"
                : "تم إنشاء المؤسسات التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
