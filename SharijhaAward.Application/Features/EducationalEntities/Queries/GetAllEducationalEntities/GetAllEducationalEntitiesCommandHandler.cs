using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntities
{
    public class GetAllEducationalEntitiesCommandHandler
        : IRequestHandler<GetAllEducationalEntitiesCommand, BaseResponse<List<EducationalEntitiesListVm>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _eucationalEntityRepository;
        private readonly IMapper _mapper;

        public GetAllEducationalEntitiesCommandHandler(IAsyncRepository<EducationalEntity> eucationalEntityRepository, IMapper mapper)
        {
            _eucationalEntityRepository = eucationalEntityRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EducationalEntitiesListVm>>> Handle(GetAllEducationalEntitiesCommand request, CancellationToken cancellationToken)
        {
            var EducationalEntities = await _eucationalEntityRepository.ListAllAsync();
            if (request.ArabicName != null && request.EnglishName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _eucationalEntityRepository
                    .Where(e => e.ArabicName.ToLower().Contains(request.ArabicName!.ToLower()) &&
                        e.EnglishName.ToLower().Contains(request.EnglishName!.ToLower())).ToList();
            }
            else if (request.EnglishName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _eucationalEntityRepository
                    .Where(e => e.EnglishName.ToLower().Contains(request.EnglishName!.ToLower())).ToList();
            }
            else if (request.ArabicName != null && EducationalEntities.Count() > 0)
            {
                EducationalEntities = _eucationalEntityRepository
                    .Where(e => e.ArabicName.ToLower().Contains(request.ArabicName!.ToLower())).ToList();
            }
            var data = _mapper.Map<List<EducationalEntitiesListVm>>(EducationalEntities);

            return new BaseResponse<List<EducationalEntitiesListVm>>("", true, 200, data);
        }
    }
}
