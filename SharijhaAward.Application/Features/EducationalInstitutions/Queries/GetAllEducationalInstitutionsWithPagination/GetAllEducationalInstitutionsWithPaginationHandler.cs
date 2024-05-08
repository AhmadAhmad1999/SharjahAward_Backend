using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;
using AutoMapper;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Application.Contract.Persistence;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsWithPagination
{
    public class GetAllEducationalInstitutionsWithPaginationHandler 
        : IRequestHandler<GetAllEducationalInstitutionsWithPaginationQuery, BaseResponse<List<EducationalInstitutionListVM>>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IMapper _Mapper;

        public GetAllEducationalInstitutionsWithPaginationHandler
            (IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository, IMapper mapper)
        {
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
            _Mapper = mapper;
        }

        public async Task<BaseResponse<List<EducationalInstitutionListVM>>> 
            Handle(GetAllEducationalInstitutionsWithPaginationQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<EducationalInstitutionListVM> EducationalInstitutions = 
                await _EducationalInstitutionRepository
                    .Where(x => x.EducationalEntityId == Request.EducationalEntityId)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new EducationalInstitutionListVM()
                    {
                        Id = x.Id,
                        Name = Request.lang == "en"
                            ? x.EnglishName
                            : x.ArabicName,
                        ArabicName = x.ArabicName,
                        EnglishName = x.EnglishName,
                        EducationType = x.EducationType,
                        Emirates = x.Emirates
                    }).ToListAsync();

            int TotalCount = await _EducationalInstitutionRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<EducationalInstitutionListVM>>(ResponseMessage, true, 200, 
                EducationalInstitutions, PaginationParameter);
        }
    }
}
