using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsers
{
    public class GetAllUsersHandler 
        : IRequestHandler<GetAllUsersQuery, BaseResponse<List<GetAllUsersListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;

        public GetAllUsersHandler(IMapper Mapper,
            IUserRepository UserRepository)
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
        }

        public async Task<BaseResponse<List<GetAllUsersListVM>>> Handle(GetAllUsersQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllUsersListVM> Users = _Mapper.Map<List<GetAllUsersListVM>>(await _UserRepository
                .Where(x => x.isValidAccount)
                .OrderByDescending(x => x.CreatedAt)
                .Skip((Request.page - 1) * Request.pageSize)
                .Take(Request.pageSize)
                .ToListAsync());

            int TotalCount = await _UserRepository.GetCountAsync(x => x.isValidAccount);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllUsersListVM>>(ResponseMessage, true, 200, Users, PaginationParameter);
        }
    }
}
