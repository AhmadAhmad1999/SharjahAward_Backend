using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingCategoryModel;
using SharijhaAward.Domain.Entities.MeetingModel;
using SharijhaAward.Domain.Entities.MeetingUserModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.CreateMeeting
{
    public class CreateMeetingHandler : IRequestHandler<CreateMeetingCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        private readonly IAsyncRepository<MeetingUser> _MeetingUserRepository;
        private readonly IAsyncRepository<MeetingCategory> _MeetingCategoryRepository;

        public CreateMeetingHandler(IMapper Mapper,
            IAsyncRepository<Meeting> MeetingRepository,
            IAsyncRepository<MeetingUser> MeetingUserRepository,
            IAsyncRepository<MeetingCategory> MeetingCategoryRepository)
        {
            _Mapper = Mapper;
            _MeetingRepository = MeetingRepository;
            _MeetingUserRepository = MeetingUserRepository;
            _MeetingCategoryRepository = MeetingCategoryRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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

                return new BaseResponse<object>(ResponseMessage, false, 404);
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
                    Meeting NewMeetingEntity = _Mapper.Map<Meeting>(Request);

                    await _MeetingRepository.AddAsync(NewMeetingEntity);

                    List<MeetingUser> NewMeetingUserEntities = Request.UsersInfo
                        .Select(x => new MeetingUser()
                        {
                            Name = x.Name,
                            Email = x.Email,
                            MeetingId = NewMeetingEntity.Id
                        }).ToList();

                    await _MeetingUserRepository.AddRangeAsync(NewMeetingUserEntities);

                    List<MeetingCategory> NewMeetingCategoryEntities = Request.CategoriesIds
                        .Select(x => new MeetingCategory()
                        {
                            CategoryId = x,
                            MeetingId = NewMeetingEntity.Id
                        }).ToList();

                    await _MeetingCategoryRepository.AddRangeAsync(NewMeetingCategoryEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الاجتماع بنجاح";

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
