using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.LoggerModel;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController
{
    public class GetHistoryByControllerHandler : IRequestHandler<GetHistoryByControllerQuery, BaseResponse<List<GetHistoryByControllerListVM>>>
    {
        private readonly IAsyncRepository<LogUserAction> _LogUserActionRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IMapper _Mapper;
        private readonly IJwtProvider _JwtProvider;

        public GetHistoryByControllerHandler(IAsyncRepository<UserRole> UserRoleRepository, IAsyncRepository<LogUserAction> LogUserActionRepository,
            IMapper Mapper,
            IJwtProvider JwtProvider)
        {
            _LogUserActionRepository = LogUserActionRepository;
            _UserRoleRepository = UserRoleRepository;
            _Mapper = Mapper;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<List<GetHistoryByControllerListVM>>> 
            Handle(GetHistoryByControllerQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));
            var UserRoles = _UserRoleRepository.Where(u => u.UserId == UserId).Select(u => u.RoleId);

            string ResponseMessage = string.Empty;
            var Response = new List<GetHistoryByControllerListVM>();


                if (UserRoles.Contains(1))
                {
                     Response = await _LogUserActionRepository
                        .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                        .Select(x => new GetHistoryByControllerListVM()
                        {
                            Id = x.Id,
                            Date = x.Date,
                            UserId = x.UserId,
                            ControllerName = x.ControllerName,
                            UserName = Request.lang == "en"
                                ? x.User!.EnglishName
                                : x.User!.ArabicName,
                            ActionType = x.HttpMethod.ToLower() == "post"
                                ? ActionsTypes.Add
                                : (x.HttpMethod.ToLower() == "put"
                                    ? ActionsTypes.Update
                                    : (x.HttpMethod.ToLower() == "delete"
                                        ? ActionsTypes.Delete : null)),
                            Result = x.Result,
                            RecordId = (x.HttpMethod.ToLower() == "put" || x.HttpMethod.ToLower() == "delete")
                                ? x.RecordId : null
                        }).ToListAsync();

                    
                }
                else
                {
                     Response = _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId, filterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Select(x => new GetHistoryByControllerListVM()
                        {
                            Id = x.Id,
                            Date = x.Date,
                            UserId = x.UserId,
                            ControllerName = x.ControllerName,
                            UserName = Request.lang == "en"
                                ? x.User!.EnglishName
                                : x.User!.ArabicName,
                            ActionType = x.HttpMethod.ToLower() == "post"
                                ? ActionsTypes.Add
                                : (x.HttpMethod.ToLower() == "put"
                                    ? ActionsTypes.Update
                                    : (x.HttpMethod.ToLower() == "delete"
                                        ? ActionsTypes.Delete : null)),
                            Result = x.Result,
                            RecordId = (x.HttpMethod.ToLower() == "put" || x.HttpMethod.ToLower() == "delete")
                                ? x.RecordId : null
                        }).ToList();

                    
                }

            if (!Request.UserName.IsNullOrEmpty())
            {
                Response = Response.Where(r => r.UserName.Contains(Request.UserName!)).ToList();
            }

            int TotalCount = await _LogUserActionRepository.GetCountAsync(c => c.isDeleted);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetHistoryByControllerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
