using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Queries.GetMeetingById
{
    public class GetMeetingByIdHandler : IRequestHandler<GetMeetingByIdQuery, BaseResponse<GetMeetingByIdDto>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IAsyncRepository<MeetingCategory> _MeetingCategoryRepository;

        public GetMeetingByIdHandler(IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IAsyncRepository<MeetingCategory> MeetingCategoryRepository)
        {
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _MeetingCategoryRepository = MeetingCategoryRepository;
        }

        public async Task<BaseResponse<GetMeetingByIdDto>> Handle(GetMeetingByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntity = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (MeetingEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not Found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<GetMeetingByIdDto>(ResponseMessage, false, 404);
            }

            List<MeetingUser> MeetingUsersEntities = await _MeetingUserRepository
                .Where(x => x.MeetingId == Request.Id)
                .ToListAsync();

            List<Category> CategoriesEntities = await _MeetingCategoryRepository
                .Where(x => x.MeetingId == Request.Id)
                .Select(x => x.Category!)
                .ToListAsync();

            GetMeetingByIdDto Response = new GetMeetingByIdDto()
            {
                ArabicName = MeetingEntity.ArabicName,
                EnglishName = MeetingEntity.EnglishName,
                ArabicDescription = MeetingEntity.ArabicDescription,
                EnglishDescription = MeetingEntity.EnglishDescription,
                Date = MeetingEntity.Date,
                Type = MeetingEntity.Type,
                UsersInfo = MeetingUsersEntities
                    .Select(x => new MeetingUserDto()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        Name = x.Name
                    }).ToList(),
                CategoriesIds = CategoriesEntities
                    .Select(x => x.Id).ToList(),
                ArabicText = MeetingEntity.ArabicText,
                EnglishText = MeetingEntity.EnglishText,
                isImplemented = MeetingEntity.isImplemented,
                isCanceled = MeetingEntity.isCanceled,
                ArabicReasonOfCanceling = MeetingEntity.ArabicReasonOfCanceling,
                EnglishReasonOfCanceling = MeetingEntity.EnglishReasonOfCanceling
            };

            return new BaseResponse<GetMeetingByIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
