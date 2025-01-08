using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ResponsibilityModel;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities
{
    public class GetAllResponsibilitiesQueryHandler
        : IRequestHandler<GetAllResponsibilitiesQuery, BaseResponse<List<ResponsibilityListVM>>>
    {
        private readonly IAsyncRepository<Responsibility> _ResponsibilityRepository;

        public GetAllResponsibilitiesQueryHandler(IAsyncRepository<Responsibility> _ResponsibilityRepository)
        {
            this._ResponsibilityRepository = _ResponsibilityRepository;
        }

        public async Task<BaseResponse<List<ResponsibilityListVM>>> Handle(GetAllResponsibilitiesQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            IReadOnlyList<Responsibility> ResponsibilitiesEntities = Request.RoleId == null
                ? await _ResponsibilityRepository
                    .OrderByDescending(FilterObject, x => x.CreatedAt, Request.page, Request.perPage)
                    .ToListAsync()
                : await _ResponsibilityRepository
                    .GetWhereThenPagedReponseAsync(r => r.RoleId == Request.RoleId, FilterObject, Request.page, Request.perPage);

            List<ResponsibilityListVM> Response = ResponsibilitiesEntities
                .Select(x => new ResponsibilityListVM()
                {
                    Id = x.Id,
                    Description = x.Description,
                    RoleId = x.RoleId,
                    RoleName = Request.lang == "en"
                        ? x.Role.EnglishName
                        : x.Role.ArabicName
                }).ToList();

            int TotalCount = Request.RoleId == null
                ? await _ResponsibilityRepository
                    .WhereThenFilter(r => true, FilterObject)
                    .CountAsync()
                : await _ResponsibilityRepository
                    .WhereThenFilter(r => r.RoleId == Request.RoleId, FilterObject)
                    .CountAsync();

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<ResponsibilityListVM>>(ResponseMessage, true, 200, Response, Pagination);
        }
    }
}
