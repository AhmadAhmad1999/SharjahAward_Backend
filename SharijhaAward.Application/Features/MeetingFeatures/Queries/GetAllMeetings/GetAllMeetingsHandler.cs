using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetAllMeetings
{
    public class GetAllMeetingsHandler : IRequestHandler<GetAllMeetingsQuery, BaseResponse<List<GetAllMeetingsListVM>>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IMapper _Mapper;
        public GetAllMeetingsHandler(IAsyncRepository<Meeting> MeetingRepository,
            IMapper Mapper)
        {
            _MeetingRepository = MeetingRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllMeetingsListVM>>> 
            Handle(GetAllMeetingsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.isCanceled is not null)
            {
                List<GetAllMeetingsListVM> Meetings = _Mapper.Map<List<GetAllMeetingsListVM>>(await _MeetingRepository
                    .Where(x => x.isCanceled == Request.isCanceled)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync());

                int TotalCount = await _MeetingRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllMeetingsListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
            else if (Request.isImplemented is not null)
            {
                List<GetAllMeetingsListVM> Meetings = _Mapper.Map<List<GetAllMeetingsListVM>>(await _MeetingRepository
                    .Where(x => x.isImplemented == Request.isImplemented)
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync());

                int TotalCount = await _MeetingRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllMeetingsListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
            else
            {
                List<GetAllMeetingsListVM> Meetings = _Mapper.Map<List<GetAllMeetingsListVM>>(await _MeetingRepository
                    .OrderByDescending(x => x.CreatedAt, Request.page, Request.pageSize).ToListAsync());

                int TotalCount = await _MeetingRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllMeetingsListVM>>(ResponseMessage, true, 200, Meetings, PaginationParameter);
            }
        }
    }
}
