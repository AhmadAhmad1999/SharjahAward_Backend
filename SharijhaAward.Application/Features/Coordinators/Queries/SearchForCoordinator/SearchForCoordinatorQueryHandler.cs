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
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IMapper _Mapper;

        public SearchForCoordinatorQueryHandler(IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IAsyncRepository<Coordinator> _CoordinatorRepository, 
            IAsyncRepository<EducationalEntity> _EducationalEntityRepository, 
            IMapper _Mapper,
            IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository,
            IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository)
        {
            this._CoordinatorRepository = _CoordinatorRepository;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            this._EducationalEntityRepository = _EducationalEntityRepository;
            this._Mapper = _Mapper;
            this._EduInstitutionCoordinatorRepository = _EduInstitutionCoordinatorRepository;
            this._EduEntitiesCoordinatorRepository = _EduEntitiesCoordinatorRepository;
        }

        public async Task<BaseResponse<List<CoordinatorSearchListVM>>> 
            Handle(SearchForCoordinatorQuery Request, CancellationToken cancellationToken)
        {
            var Coordinators = await _CoordinatorRepository
                .Where(x => true).ToListAsync();
            
            var CoordinatorsResult = Coordinators;

            if (Request.Emirates != null || Request.EducationType != null)
            {
                var EducationalInstitutionParam = Expression.Parameter(typeof(EducationalInstitution), "I");
                
                var filters = new List<Expression>();

                if (Request.Emirates != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(EducationalInstitutionParam, "Emirates"),
                        Expression.Constant(Request.Emirates)));
                }
                if (Request.EducationType != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(EducationalInstitutionParam, "EducationType"),
                        Expression.Constant(Request.EducationType)));
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
                

                var EduEntities = await _EducationalInstitutionRepository.Where(predicate1).Select(e=>e.EducationalEntity).ToListAsync();

                CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                    .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                    .Select(x => x.Coordinator!)
                    .ToListAsync();

                if (Request.EducationalEntity != null)
                {   
                    EduEntities = EduEntities
                        .Where(x => x.Id == Request.EducationalEntity).ToList();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                        .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                        .Select(x => x.Coordinator!)
                        .ToListAsync();

                    if (Request.School != null)
                    {

                        EduEntities = await _EducationalInstitutionRepository
                            .Where(x => x.Id == Request.School)
                            .Where(x => EduEntities.Select(e => e.Id).Contains(x.EducationalEntityId))
                            .Where(predicate1)
                            .Select(e => e.EducationalEntity).ToListAsync();

                        CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                           .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                           .Select(x => x.Coordinator!)
                           .ToListAsync();

                    }
                }

                if (Request.School != null)
                {
                    EduEntities = await _EducationalInstitutionRepository
                        .Where(x => x.Id == Request.School)
                        .Where(predicate1)
                        .Select(e => e.EducationalEntity).ToListAsync();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                       .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                       .Select(x => x.Coordinator!)
                       .ToListAsync();

                }
            }
            else if (Request.EducationalEntity != null)
            {
               var EduEntities = _EducationalEntityRepository
                    .Where(x => x.Id == Request.EducationalEntity).ToList();

               CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                   .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                   .Select(x => x.Coordinator!)
                   .ToListAsync();

                if (Request.School != null)
                {
                    EduEntities = await _EducationalInstitutionRepository
                        .Where(x => x.Id == Request.School)
                        .Select(e => e.EducationalEntity).ToListAsync();

                    CoordinatorsResult = await _EduEntitiesCoordinatorRepository
                       .Where(x => EduEntities.Select(y => y.Id).Contains(x.EducationalEntityId))
                       .Select(x => x.Coordinator!)
                       .ToListAsync();

                }
            }
            else if (Request.School != null)
            {

                var EduEntities = await _EducationalInstitutionRepository
                    .Where(x => x.Id == Request.School)
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
            var data = _Mapper.Map<List<CoordinatorSearchListVM>>(CoordinatorsResult);

            for (int i = 0; i < data.Count; i++)
            {
                data[i].Name = Request.lang == "en"
                    ? CoordinatorsResult[i].EnglishName
                    : CoordinatorsResult[i].ArabicName;
            }

            return new  BaseResponse<List<CoordinatorSearchListVM>>("", true, 200, data);
                
        }
    }
}
