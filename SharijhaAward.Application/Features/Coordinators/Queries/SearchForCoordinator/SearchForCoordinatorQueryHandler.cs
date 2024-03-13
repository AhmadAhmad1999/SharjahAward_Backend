using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

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

            if (
                    request.Emirates==null &&
                    request.EducationType == null &&
                    request.EducationalEntity == null && 
                    request.Shcool == null
                )
            {
                 Coordinators = (List<Coordinator>) await _coordinatorRepository.ListAllAsync();
            }

             Coordinators = _coordinatorRepository
               .Include(c => c.EducationCoordinators)
               .Where(c =>
                  c.EducationCoordinators.Any(ec =>
                     ec.EducationalEntityId == request.EducationalEntity) &&
                  c.EducationType == request.EducationType &&
                  c.Emirates == request.Emirates
               ).ToList();

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
