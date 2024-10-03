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
            FilterObject FilterObject = new FilterObject() { Filters = Request.filters };

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));
            UserRole? UserRoles = await _UserRoleRepository
                .FirstOrDefaultAsync(x => x.UserId == UserId && x.Role!.HaveFullAccess);

            string ResponseMessage = string.Empty;
            var Response = new List<GetHistoryByControllerListVM>();

            int TotalCount = 0;

            if (UserRoles is not null)
            {
                if (!Request.UserName.IsNullOrEmpty() && Request.lang == "en")
                {
                    Response = await _LogUserActionRepository
                        .WhereThenFilter(x => x.User!.EnglishName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .OrderByDescending(x => x.Id)
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
                        }).ToListAsync();

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => x.User!.EnglishName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .CountAsync();
                }
                else if (!Request.UserName.IsNullOrEmpty() && Request.lang == "ar")
                {
                    Response = await _LogUserActionRepository
                        .WhereThenFilter(x => x.User!.ArabicName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .OrderByDescending(x => x.Id)
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
                        }).ToListAsync();

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => x.User!.ArabicName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .CountAsync();
                }
                else
                {
                    Response = await _LogUserActionRepository
                        .WhereThenFilter(x => true, FilterObject)
                        .OrderByDescending(x => x.Id)
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
                        }).ToListAsync();

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => true, FilterObject)
                        .CountAsync();
                }
            }
            else
            {
                if (!Request.UserName.IsNullOrEmpty() && Request.lang == "en")
                {
                    Response = _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId &&
                            x.User!.EnglishName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
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

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId &&
                            x.User!.EnglishName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .CountAsync();
                }
                else if (!Request.UserName.IsNullOrEmpty() && Request.lang == "ar")
                {
                    Response = _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId &&
                            x.User!.ArabicName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
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

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId &&
                            x.User!.ArabicName.ToLower().Contains(Request.UserName!.ToLower()), FilterObject)
                        .CountAsync();
                }
                else
                {
                    Response = _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId, FilterObject)
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

                    TotalCount = await _LogUserActionRepository
                        .WhereThenFilter(x => x.UserId == UserId, FilterObject)
                        .CountAsync();
                }
            }

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetHistoryByControllerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
