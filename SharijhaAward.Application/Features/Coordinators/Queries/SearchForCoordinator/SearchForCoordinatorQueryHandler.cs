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
        private readonly IMapper _mapper;

        public SearchForCoordinatorQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository,IAsyncRepository<Coordinator> coordinatorRepository, IAsyncRepository<EduEntitiesCoordinator> educationalEntityRepository, IMapper mapper)
        {
            _coordinatorRepository = coordinatorRepository;
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _educationalEntityRepository = educationalEntityRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CoordinatorSearchListVM>>> Handle(SearchForCoordinatorQuery request, CancellationToken cancellationToken)
        {
            var Coordinators = await _coordinatorRepository.Include(c=>c.EducationCoordinators!).Include(c => c.InstitutionCoordinators).ToListAsync();
            if (request.Emirates != null || request.EducationType != null)
            {

                var CoordinatorParam = Expression.Parameter(typeof(Coordinator), "c");
               
                var filters = new List<Expression>();

                if (request.Emirates != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(CoordinatorParam, "Emirates"),
                        Expression.Constant(request.Emirates)));
                }
                if (request.EducationType != null)
                {
                    filters.Add(Expression.Equal(
                        Expression.Property(CoordinatorParam, "EducationType"),
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
                var predicate1 = Expression.Lambda<Func<Coordinator, bool>>(
                      predicateBody, CoordinatorParam);


                 Coordinators = await _coordinatorRepository.WhereThenInclude(predicate1, c => c.EducationCoordinators!).Include(c=>c.InstitutionCoordinators).ToListAsync();
            }

            if (request.EducationalEntity != null)
            {

                Coordinators = Coordinators
                     .Where(x => x.EducationCoordinators!
                     .Any(ec => ec.EducationalEntityId == request.EducationalEntity)).ToList();

            }

            if(request.Shcool != null)
            {
                Coordinators = Coordinators
                     .Where(x => x.InstitutionCoordinators!
                     .Any(ec => ec.EducationalInstitutionId == request.Shcool)).ToList();
            }
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
