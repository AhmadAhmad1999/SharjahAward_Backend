using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.UpdateMeeting
{
    public class UpdateMeetingHandler : IRequestHandler<UpdateMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IAsyncRepository<MeetingCategory> _MeetingCategoryRepository;
        private readonly IMapper _Mapper;

        public UpdateMeetingHandler(IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IAsyncRepository<MeetingCategory> MeetingCategoryRepository,
            IMapper Mapper)
        {
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _MeetingCategoryRepository = MeetingCategoryRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (string.IsNullOrEmpty(Request.MeetingLink) && Request.Type == Domain.Constants.MeetingTypes.Virtual)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"When the meeting type is virtual, then you have to enter a value for the meeting link"
                    : $"عندما يكون نوع الاجتماع افتراضيًا، فيجب عليك إدخال قيمة لرابط الاجتماع";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (!string.IsNullOrEmpty(Request.MeetingLink) && Request.Type == Domain.Constants.MeetingTypes.OnSite)
            {
                ResponseMessage = Request.lang == "en"
                    ? $"you can't insert a value for the meeting link unless the meeting type is virtual"
                    : $"لا يمكنك إدخال قيمة لرابط الاجتماع إلا في حالة كون نوع الاجتماع افتراضياً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            List<string> CheckForDuplicatedEmails = Request.UsersInfo
                .GroupBy(m => m.Email.ToLower())
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .ToList();

            if (CheckForDuplicatedEmails.Any())
            {
                ResponseMessage = Request.lang == "en"
                    ? $"The following emails are duplicated: {string.Join(", ", CheckForDuplicatedEmails)}"
                    : $"البُرُد الإلكترونية التالية مكررة: {string.Join(", ", CheckForDuplicatedEmails)}";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    Meeting? MeetingEntity = await _MeetingRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (MeetingEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Meeting is not Found"
                            : "الاجتماع غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    _Mapper.Map(Request, MeetingEntity, typeof(UpdateMeetingCommand), typeof(Meeting));
                    await _MeetingRepository.UpdateAsync(MeetingEntity);

                    List<MeetingUser> OldMeetingUserEntities = await _MeetingUserRepository
                        .Where(x => x.MeetingId == Request.Id)
                        .ToListAsync();

                    await _MeetingUserRepository.DeleteListAsync(OldMeetingUserEntities);

                    List<MeetingUser> NewMeetingUserEntities = Request.UsersInfo
                        .Select(x => new MeetingUser()
                        {
                            Name = x.Name,
                            Email = x.Email,
                            MeetingId = Request.Id
                        }).ToList();

                    await _MeetingUserRepository.AddRangeAsync(NewMeetingUserEntities);

                    List<MeetingCategory> OldMeetingCategoryEntities = await _MeetingCategoryRepository
                        .Where(x => x.MeetingId == Request.Id)
                        .ToListAsync();

                    await _MeetingCategoryRepository.DeleteListAsync(OldMeetingCategoryEntities);

                    List<MeetingCategory> NewMeetingCategoryEntities = Request.CategoriesIds
                        .Select(x => new MeetingCategory()
                        {
                            CategoryId = x,
                            MeetingId = Request.Id
                        }).ToList();

                    await _MeetingCategoryRepository.AddRangeAsync(NewMeetingCategoryEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل الاجتماع بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
