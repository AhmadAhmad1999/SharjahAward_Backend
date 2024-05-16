using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateInterview
{
    public class CreateInterviewHandler : IRequestHandler<CreateInterviewCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IAsyncRepository<InterviewCategory> _InterviewCategoryRepository;
        private readonly IAsyncRepository<InterviewNote> _InterviewNoteRepository;
        private readonly IAsyncRepository<InterviewQuestion> _InterviewQuestionRepository;

        public CreateInterviewHandler(IMapper Mapper,
            IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IAsyncRepository<InterviewCategory> InterviewCategoryRepository,
             IAsyncRepository<InterviewNote> InterviewNoteRepository,
             IAsyncRepository<InterviewQuestion> InterviewQuestionRepository)
        {
            _Mapper = Mapper;
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _InterviewCategoryRepository = InterviewCategoryRepository;
            _InterviewNoteRepository = InterviewNoteRepository;
            _InterviewQuestionRepository = InterviewQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateInterviewCommand Request, CancellationToken cancellationToken)
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
                    Interview NewInterviewEntity = _Mapper.Map<Interview>(Request);

                    await _InterviewRepository.AddAsync(NewInterviewEntity);

                    List<InterviewUser> NewInterviewUserEntities = Request.UsersInfo
                        .Select(x => new InterviewUser()
                        {
                            Name = x.Name,
                            Email = x.Email,
                            InterviewId = NewInterviewEntity.Id
                        }).ToList();

                    await _InterviewUserRepository.AddRangeAsync(NewInterviewUserEntities);
                    
                    List<InterviewCategory> NewInterviewCategoryEntities = Request.CategoriesIds
                        .Select(x => new InterviewCategory()
                        {
                            CategoryId = x,
                            InterviewId = NewInterviewEntity.Id
                        }).ToList();

                    await _InterviewCategoryRepository.AddRangeAsync(NewInterviewCategoryEntities);

                    IEnumerable<InterviewNote> NewInterviewNoteEntities = Request.InterviewNoteDtos
                        .Select(x => new InterviewNote()
                        {
                            InterviewId = NewInterviewEntity.Id,
                            ArabicNote = x.ArabicNote,
                            EnglishNote = x.EnglishNote
                        });

                    await _InterviewNoteRepository.AddRangeAsync(NewInterviewNoteEntities);

                    IEnumerable<InterviewQuestion> NewInterviewQuestionEntities = Request.InterviewQuestionDtos
                        .Select(x => new InterviewQuestion()
                        {
                            InterviewId = NewInterviewEntity.Id,
                            ArabicQuestion = x.ArabicQuestion,
                            EnglishQuestion = x.EnglishQuestion
                        });

                    await _InterviewQuestionRepository.AddRangeAsync(NewInterviewQuestionEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المقابلة بنجاح";

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