using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class SearchForCoordinatorQueryHandler
        : IRequestHandler<SearchForCoordinatorQuery, BaseResponse<List<CoordinatorSearchListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _educationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IMapper _mapper;

        public SearchForCoordinatorQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository,IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<EduEntitiesCoordinator> educationalEntityRepository, IMapper mapper,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _mapper = mapper;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
        }

        public async Task<BaseResponse<List<CoordinatorSearchListVM>>> Handle(SearchForCoordinatorQuery request, CancellationToken cancellationToken)
        {
            var Coordinators = await _coordinatorRepository.Include(c => c.InstitutionCoordinators!).ToListAsync();
            
            var CoordinatorsResult = Coordinators;

            if (request.Emirates != null || request.EducationType != null)
            {
                var EducationalInstitutionParam = Expression.Parameter(typeof(EducationalInstitution), "I");
                
                var filters = new List<Expression>();

                if (request.Emirates != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(EducationalInstitutionParam, "Emirates"),
                        Expression.Constant(request.Emirates)));
                }
                if (request.EducationType != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(EducationalInstitutionParam, "EducationType"),
                        Expression.Constant(request.EducationType)));
                }
                
                var predicateBody = filters[0];

                for (int i = 1; i < filters.Count; i++)
                {
                    predicateBody = Expression.MakeBinary(
                      ExpressionType.And,
                      predicateBody,
                      filters[i]
                    );
                }
                var predicate1 = Expression.Lambda<Func<EducationalInstitution, bool>>(
                      predicateBody, EducationalInstitutionParam);

                var EducationalInstitutions = await _educationalInstitutionRepository.Where(predicate1).ToListAsync();

                CoordinatorsResult = await _EduInstitutionCoordinatorRepository
                    .Include(x => x.Coordinator!)
                    .Where(x => EducationalInstitutions.Select(y => y.Id).Contains(x.EducationalInstitutionId))
                    .Select(x => x.Coordinator!)
                    .ToListAsync();

                if (request.EducationalEntity != null)
                {
                     CoordinatorsResult = await _EduInstitutionCoordinatorRepository
                        .Include(x => x.EducationalInstitution!)
                        .Where(x => x.EducationalInstitution!.EducationalEntityId == request.EducationalEntity)
                        .Where(x=>x.EducationalInstitution.Emirates == request.Emirates && x.EducationalInstitution.EducationType == request.EducationType)
                        .Include(x => x.Coordinator!)
                        .Select(x => x.Coordinator!)
                        .ToListAsync();

                    if (request.School != null)
                    {
                        CoordinatorsResult = _EduInstitutionCoordinatorRepository
                            .Include(x => x.Coordinator!)
                            .Where(x => x.EducationalInstitutionId == request.School)
                            .Where(x => x.EducationalInstitution.Emirates == request.Emirates && x.EducationalInstitution.EducationType == request.EducationType)
                            .Where(x => x.EducationalInstitution.EducationalEntityId == request.EducationalEntity)
                            .Select(x => x.Coordinator)
                            .ToList()!;
                    }
                }

                if (request.School != null)
                {
                    CoordinatorsResult = _EduInstitutionCoordinatorRepository
                        .Include(x => x.Coordinator!)
                        .Where(x => x.EducationalInstitutionId == request.School)
                        .Where(x => x.EducationalInstitution.Emirates == request.Emirates && x.EducationalInstitution.EducationType == request.EducationType)
                        .Select(x => x.Coordinator)
                        .ToList()!;
                }
            }
            else if (request.EducationalEntity != null)
            {
                CoordinatorsResult = await _EduInstitutionCoordinatorRepository
                   .Include(x => x.EducationalInstitution!)
                   .Where(x => x.EducationalInstitution!.EducationalEntityId == request.EducationalEntity)
                   .Include(x => x.Coordinator!)
                   .Select(x => x.Coordinator!)
                   .ToListAsync();

                if (request.School != null)
                {
                    CoordinatorsResult = _EduInstitutionCoordinatorRepository
                        .Include(x => x.Coordinator!)
                        .Where(x => x.EducationalInstitutionId == request.School)
                        .Where(x => x.EducationalInstitution.EducationalEntityId == request.EducationalEntity)
                        .Select(x => x.Coordinator)
                        .ToList()!;

                }
            }
            else if (request.School != null)
            {
                CoordinatorsResult = _EduInstitutionCoordinatorRepository
                    .Include(x => x.Coordinator!)
                    .Where(x => x.EducationalInstitutionId == request.School)
                    .Select(x => x.Coordinator)
                    .ToList()!;
            }

            var data = _mapper.Map<List<CoordinatorSearchListVM>>(CoordinatorsResult);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Name = request.lang == "en"
                    ? CoordinatorsResult[i].EnglishName
                    : CoordinatorsResult[i].ArabicName;
            }

            return new  BaseResponse<List<CoordinatorSearchListVM>>("", true, 200, data);
                
        }
    }
}
