using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById
{
    public class GetEducationalEntityByIdHandler : IRequestHandler<GetEducationalEntityByIdQuery, BaseResponse<GetEducationalEntityByIdDto>>
    {
        private readonly IAsyncRepository<EducationalEntity> _EducationEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IMapper _Mapper;
        public GetEducationalEntityByIdHandler(IAsyncRepository<EducationalEntity> EducationEntityRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IMapper Mapper)
        {
            _EducationEntityRepository = EducationEntityRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetEducationalEntityByIdDto>> Handle(GetEducationalEntityByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalEntity? EducationalEntity = await _EducationEntityRepository
                .FirstOrDefaultAsync(x => x.Id == Request.EducationEntityId);

            if (EducationalEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational entity is not Found"
                    : "الجهة التعليمية غير موجودة";

                return new BaseResponse<GetEducationalEntityByIdDto>(ResponseMessage, false, 404);
            }

            GetEducationalEntityByIdDto GetEducationEntityByIdDto = _Mapper.Map<GetEducationalEntityByIdDto>(EducationalEntity);

            GetEducationEntityByIdDto.EducationalInstitutions = await _EducationalInstitutionRepository
                .Where(x => x.EducationalEntityId == Request.EducationEntityId)
                .Select(x => new EducationalInstitutionListVM()
                {
                    Id = x.EducationalEntity!.Id,
                    ArabicName = x.EducationalEntity!.ArabicName,
                    EnglishName = x.EducationalEntity!.EnglishName
                }).ToListAsync();

            return new BaseResponse<GetEducationalEntityByIdDto>(ResponseMessage, true, 200, GetEducationEntityByIdDto);
        }
    }
}
