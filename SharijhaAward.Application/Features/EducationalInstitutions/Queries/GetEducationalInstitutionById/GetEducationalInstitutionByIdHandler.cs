using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetEducationalInstitutionById
{
    public class GetEducationalInstitutionByIdHandler
        : IRequestHandler<GetEducationalInstitutionByIdQuery, BaseResponse<GetEducationalInstitutionByIdDto>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IMapper _Mapper;
        public GetEducationalInstitutionByIdHandler(IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository,
            IMapper Mapper)
        {
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<GetEducationalInstitutionByIdDto>> 
            Handle(GetEducationalInstitutionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EducationalInstitution? EducationalInstitutionEntity = await _EducationalInstitutionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (EducationalInstitutionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Educational institution is not Found"
                    : "المؤسسة التعليمية غير موجودة";

                return new BaseResponse<GetEducationalInstitutionByIdDto>(ResponseMessage, false, 404);
            }

            GetEducationalInstitutionByIdDto GetEducationalInstitutionByIdDto = _Mapper.Map<GetEducationalInstitutionByIdDto>
                (EducationalInstitutionEntity);

            return new BaseResponse<GetEducationalInstitutionByIdDto>(ResponseMessage, true, 200, GetEducationalInstitutionByIdDto);
        }
    }
}
