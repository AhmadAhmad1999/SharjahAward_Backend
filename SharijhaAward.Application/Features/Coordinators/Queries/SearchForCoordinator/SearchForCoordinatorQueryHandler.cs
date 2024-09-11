using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using System.Linq.Expressions;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class SearchForCoordinatorQueryHandler
        : IRequestHandler<SearchForCoordinatorQuery, BaseResponse<List<CoordinatorSearchListVM>>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IMapper _mapper;

        public SearchForCoordinatorQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository,IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<EducationalEntity> educationalEntityRepository, IMapper mapper,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _mapper = mapper;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
        }

        public async Task<BaseResponse<List<CoordinatorSearchListVM>>> Handle(SearchForCoordinatorQuery request, CancellationToken cancellationToken)
        {
            var Coordinators = await _coordinatorRepository
                .Where(x => true).ToListAsync();
            
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
                

                var EduEntities = await _educationalInstitutionRepository.Where(predicate1).Select(e=>e.EducationalEntity).ToListAsync();

                CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                    .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                    .Select(x => x.Coordinator!)
                    .ToListAsync();

                if (request.EducationalEntity != null)
                {   
                    EduEntities = EduEntities
                        .Where(x => x.Id == request.EducationalEntity).ToList();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                        .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                        .Select(x => x.Coordinator!)
                        .ToListAsync();

                    if (request.School != null)
                    {

                        EduEntities = await _educationalInstitutionRepository
                            .Where(x => x.Id == request.School)
                            .Where(x => EduEntities.Select(e => e.Id).Contains(x.EducationalEntityId))
                            .Where(predicate1)
                            .Select(e => e.EducationalEntity).ToListAsync();

                        CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                           .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                           .Select(x => x.Coordinator!)
                           .ToListAsync();

                    }
                }

                if (request.School != null)
                {
                    EduEntities = await _educationalInstitutionRepository
                        .Where(x => x.Id == request.School)
                        .Where(predicate1)
                        .Select(e => e.EducationalEntity).ToListAsync();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                       .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                       .Select(x => x.Coordinator!)
                       .ToListAsync();

                }
            }
            else if (request.EducationalEntity != null)
            {

               var EduEntities = _educationalEntityRepository
                        .Where(x => x.Id == request.EducationalEntity).ToList();

               CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                   .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                   .Select(x => x.Coordinator!)
                   .ToListAsync();

                if (request.School != null)
                {

                    EduEntities = await _educationalInstitutionRepository
                        .Where(x => x.Id == request.School)
                        .Select(e => e.EducationalEntity).ToListAsync();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                       .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                       .Select(x => x.Coordinator!)
                       .ToListAsync();

                }
            }
            else if (request.School != null)
            {

                var EduEntities = await _educationalInstitutionRepository
                    .Where(x => x.Id == request.School)
                    .Select(e => e.EducationalEntity).ToListAsync();

                CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                    .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                    .Select(x => x.Coordinator!)
                    .ToListAsync();

            }
            else
            {
                CoordinatorsResult.Clear();
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
