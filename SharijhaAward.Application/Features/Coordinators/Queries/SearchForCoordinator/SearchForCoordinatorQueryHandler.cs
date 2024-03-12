using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class SearchForCoordinatorQueryHandler
        : IRequestHandler<SearchForCoordinatorQuery, BaseResponse<List<CoordinatorSearchListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IMapper _mapper;

        public SearchForCoordinatorQueryHandler(IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<EducationalEntity> educationalEntityRepository, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CoordinatorSearchListVM>>> Handle(SearchForCoordinatorQuery request, CancellationToken cancellationToken)
        {
            List<Coordinator> Coordinators;
            if (request.Emirates==null && request.EducationType == null)
            {
                 Coordinators = (List<Coordinator>)await _coordinatorRepository.ListAllAsync();
            }
            
             Coordinators = _coordinatorRepository
                .Where(c =>
                c.EducationType == request.EducationType &&
                c.Emirates == request.Emirates).ToList();
            
            var data = _mapper.Map<List<CoordinatorSearchListVM>>(Coordinators);
            for (int i = 0; i < data.Count; i++)
            {
                data[i].Name = request.lang == "en"
                    ? Coordinators[i].EnglishName
                    : Coordinators[i].ArabicName;
            }
            return new  BaseResponse<List<CoordinatorSearchListVM>>("", true, 200, data);
                
        }
    }
}
