using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetInterviewById
{
    public class GetInterviewByIdHandler : IRequestHandler<GetInterviewByIdQuery, BaseResponse<GetInterviewByIdDto>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IAsyncRepository<InterviewCategory> _InterviewCategoryRepository;
        private readonly IAsyncRepository<InterviewNote> _InterviewNoteRepository;
        private readonly IAsyncRepository<InterviewQuestion> _InterviewQuestionRepository;

        public GetInterviewByIdHandler(IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IAsyncRepository<InterviewCategory> InterviewCategoryRepository,
            IAsyncRepository<InterviewNote> InterviewNoteRepository,
            IAsyncRepository<InterviewQuestion> InterviewQuestionRepository)
        {
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _InterviewCategoryRepository = InterviewCategoryRepository;
            _InterviewNoteRepository = InterviewNoteRepository;
            _InterviewQuestionRepository = InterviewQuestionRepository;
        }

        public async Task<BaseResponse<GetInterviewByIdDto>> Handle(GetInterviewByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<GetInterviewByIdDto>(ResponseMessage, false, 404);
            }

            List<InterviewUser> InterviewUsersEntities = await _InterviewUserRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<Category> CategoriesEntities = await _InterviewCategoryRepository
                .Where(x => x.InterviewId == Request.Id)
                .Select(x => x.Category!)
                .ToListAsync();

            List<InterviewNote> InterviewNoteEntities = await _InterviewNoteRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<InterviewQuestion> InterviewQuestionEntities = await _InterviewQuestionRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            GetInterviewByIdDto Response = new GetInterviewByIdDto()
            {
                ArabicName = InterviewEntity.ArabicName,
                EnglishName = InterviewEntity.EnglishName,
                ArabicDescription = InterviewEntity.ArabicDescription,
                EnglishDescription = InterviewEntity.EnglishDescription,
                StartDate = InterviewEntity.StartDate,
                Type = InterviewEntity.Type,
                UsersInfo = InterviewUsersEntities
                    .Select(x => new InterviewUserDto()
                    {
                        Id = x.Id,
                        Email = x.Email,
                        Name = x.Name
                    }).ToList(),
                CategoriesIds = CategoriesEntities
                    .Select(x => x.Id).ToList(),
                ArabicText = InterviewEntity.ArabicText,
                EnglishText = InterviewEntity.EnglishText,
                isImplemented = InterviewEntity.isImplemented,
                isCanceled = InterviewEntity.isCanceled,
                ArabicReasonOfCanceling = InterviewEntity.ArabicReasonOfCanceling,
                EnglishReasonOfCanceling = InterviewEntity.EnglishReasonOfCanceling,
                GetInterviewNoteDtos = InterviewNoteEntities
                    .Select(x => new GetInterviewNoteDto()
                    {
                        Id = x.Id,
                        ArabicNote = x.ArabicNote,
                        EnglishNote = x.EnglishNote
                    }).ToList(),
                GetInterviewQuestionDtos = InterviewQuestionEntities
                    .Select(x => new GetInterviewQuestionDto()
                    {
                        Id = x.Id,
                        ArabicQuestion = x.ArabicQuestion,
                        EnglishQuestion = x.EnglishQuestion
                    }).ToList(),
                Address = InterviewEntity.Address,
                EndDate = InterviewEntity.EndDate
            };

            return new BaseResponse<GetInterviewByIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
