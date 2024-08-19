using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.LoggerModel;

namespace SharijhaAward.Application.Features.LoggerFeatures.Queries.GetHistoryByController
{
    public class GetHistoryByControllerHandler : IRequestHandler<GetHistoryByControllerQuery, BaseResponse<List<GetHistoryByControllerListVM>>>
    {
        private readonly IAsyncRepository<LogUserAction> _LogUserActionRepository;
        private readonly IMapper _Mapper;
        private readonly IJwtProvider _JwtProvider;

        public GetHistoryByControllerHandler(IAsyncRepository<LogUserAction> LogUserActionRepository,
            IMapper Mapper,
            IJwtProvider JwtProvider)
        {
            _LogUserActionRepository = LogUserActionRepository;
            _Mapper = Mapper;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<List<GetHistoryByControllerListVM>>> 
            Handle(GetHistoryByControllerQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.ShowAll)
            {
                List<GetHistoryByControllerListVM> Response = _LogUserActionRepository
                    .Where(x => x.ControllerName.ToLower() == Request.ControllerName.ToLower())
                    .Include(x => x.User!)
                    .AsEnumerable()
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetHistoryByControllerListVM()
                    {
                        Id = x.Id,
                        Date = x.Date,
                        UserId = x.UserId,
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

                int TotalCount = await _LogUserActionRepository
                    .GetCountAsync(x => x.ControllerName.ToLower() == Request.ControllerName.ToLower());

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetHistoryByControllerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
            else
            {
                int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

                List<GetHistoryByControllerListVM> Response = _LogUserActionRepository
                    .Where(x => x.ControllerName.ToLower() == Request.ControllerName.ToLower() &&
                        x.UserId == UserId)
                    .Include(x => x.User!)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .Select(x => new GetHistoryByControllerListVM()
                    {
                        Id = x.Id,
                        Date = x.Date,
                        UserId = x.UserId,
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

                int TotalCount = await _LogUserActionRepository.GetCountAsync(x => x.UserId == UserId &&
                    x.ControllerName.ToLower() == Request.ControllerName.ToLower());

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<GetHistoryByControllerListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
            }
        }
    }
}
