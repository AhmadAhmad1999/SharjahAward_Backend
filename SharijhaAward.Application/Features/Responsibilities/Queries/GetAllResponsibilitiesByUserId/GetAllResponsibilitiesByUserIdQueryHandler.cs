using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdQueryHandler
        : IRequestHandler<GetAllResponsibilitiesByUserIdQuery, BaseResponse<List<GetAllResponsibilitiesByUserIdListVM>>>
    {
        
        private readonly IAsyncRepository<ResponsibilityUser> _ResponsibilityUserRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllResponsibilitiesByUserIdQueryHandler(IAsyncRepository<ResponsibilityUser> _ResponsibilityUserRepository,
            IJwtProvider _JwtProvider)
        {
            this._ResponsibilityUserRepository = _ResponsibilityUserRepository;
            this._JwtProvider = _JwtProvider;
        }

        public async Task<BaseResponse<List<GetAllResponsibilitiesByUserIdListVM>>> 
            Handle(GetAllResponsibilitiesByUserIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.UserId is null && string.IsNullOrEmpty(Request.UserToken))
            {
                ResponseMessage = Request.lang == "en"
                    ? "You must send either the user id directly or the token"
                    : "يجب إرسال إحدى قيمتي معرف المستخدم او توكين فعالة له";

                return new BaseResponse<List<GetAllResponsibilitiesByUserIdListVM>>(ResponseMessage, false, 400);
            }

            int UserId = Request.UserId != null
                ? Request.UserId.Value
                : int.Parse(_JwtProvider.GetUserIdFromToken(Request.UserToken!));

            List<GetAllResponsibilitiesByUserIdListVM> Response = await _ResponsibilityUserRepository
                .Where(x => x.UserId == UserId)
                .Select(x => new GetAllResponsibilitiesByUserIdListVM()
                {
                    Description = x.Responsibility!.Description,
                    ResponsibilityId = x.ResponsibilityId,
                    isAccept = x.IsAccept
                }).ToListAsync();

            return new BaseResponse<List<GetAllResponsibilitiesByUserIdListVM>>(ResponseMessage, true, 200, Response);
        }
    } 
}
