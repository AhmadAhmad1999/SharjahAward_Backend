using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions
{
    public class GetAllEducationalInstitutionsQueryHandler
        : IRequestHandler<GetAllEducationalInstitutionsQuery, BaseResponse<List<EducationalInstitutionListVM>>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IMapper _mapper;

        public GetAllEducationalInstitutionsQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository, IMapper mapper)
        {
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EducationalInstitutionListVM>>> Handle(GetAllEducationalInstitutionsQuery request, CancellationToken cancellationToken)
        {
            var EducationalInstitution = await _educationalInstitutionRepository.ListAllAsync();
            if (request.EducationalEntityId != null || EducationalInstitution.Count() > 0)
            {
                EducationalInstitution = _educationalInstitutionRepository.Where(e => e.EducationalEntityId == request.EducationalEntityId).ToList();
            }

            var data = _mapper.Map<List<EducationalInstitutionListVM>>(EducationalInstitution);
            for(int i = 0; i < data.Count(); i++)
            {
                data[i].Name = request.lang == "en"
                    ? data[i].EnglishName
                    : data[i].ArabicName;
            }
            return new BaseResponse<List<EducationalInstitutionListVM>>("", true, 200, data);
        }
    }
}
