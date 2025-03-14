﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetAllRoles
{
    public class GetAllRolesHandler : IRequestHandler<GetAllRolesQuery, BaseResponse<List<GetAllRolesListVM>>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IMapper _Mapper;
        public GetAllRolesHandler(IAsyncRepository<Role> RoleRepository,
            IMapper Mapper)
        {
            _RoleRepository = RoleRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllRolesListVM>>> Handle(GetAllRolesQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
            
            string ResponseMessage = string.Empty;

            List<GetAllRolesListVM> Roles = new List<GetAllRolesListVM>();
            
            if (Request.page != 0 &&
                Request.perPage != -1)
            {
                Roles = await _RoleRepository
                    .WhereThenFilter(x => true, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetAllRolesListVM()
                    {
                        Id = x.Id,
                        ArabicName = x.ArabicName,
                        EnglishName = x.EnglishName,
                        isMainRole = (x.EnglishName != "Arbitrator" && x.ArabicName != "محكم") ||
                            (x.EnglishName != "Coordinator" && x.ArabicName != "منسق") ? true : false
                    }).ToListAsync();
            }
            else
            {
                Roles = await _RoleRepository
                    .WhereThenFilter(x => true, filterObject)
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new GetAllRolesListVM()
                    {
                        Id = x.Id,
                        ArabicName = x.ArabicName,
                        EnglishName = x.EnglishName,
                        isMainRole = (x.EnglishName != "Arbitrator" && x.ArabicName != "محكم") ||
                            (x.EnglishName != "Coordinator" && x.ArabicName != "منسق") ? true : false
                    }).ToListAsync();
            }

            int TotalCount = await _RoleRepository.WhereThenFilter(a => true, filterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllRolesListVM>>(ResponseMessage, true, 200, Roles, PaginationParameter);
        }
    }
}
