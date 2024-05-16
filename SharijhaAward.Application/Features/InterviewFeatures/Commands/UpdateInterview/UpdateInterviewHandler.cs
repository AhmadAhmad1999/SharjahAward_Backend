using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.UpdateInterview
{
    public class UpdateInterviewHandler : IRequestHandler<UpdateInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewUser> _InterviewUserRepository;
        private readonly IAsyncRepository<InterviewCategory> _InterviewCategoryRepository;
        private readonly IAsyncRepository<InterviewNote> _InterviewNoteRepository;
        private readonly IAsyncRepository<InterviewQuestion> _InterviewQuestionRepository;
        private readonly IMapper _Mapper;

        public UpdateInterviewHandler(IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewUser> InterviewUserRepository,
            IAsyncRepository<InterviewCategory> InterviewCategoryRepository,
            IAsyncRepository<InterviewNote> InterviewNoteRepository,
            IAsyncRepository<InterviewQuestion> InterviewQuestionRepository,
            IMapper Mapper)
        {
            _InterviewRepository = InterviewRepository;
            _InterviewUserRepository = InterviewUserRepository;
            _InterviewCategoryRepository = InterviewCategoryRepository;
            _InterviewNoteRepository = InterviewNoteRepository;
            _InterviewQuestionRepository = InterviewQuestionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateInterviewCommand Request, CancellationToken cancellationToken)
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

            List<InterviewNote> InterviewNoteEntitiesToDelete = await _InterviewNoteRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

            List<InterviewQuestion> InterviewQuestionEntitiesToDelete = await _InterviewQuestionRepository
                .Where(x => x.InterviewId == Request.Id)
                .ToListAsync();

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
                    Interview? InterviewEntity = await _InterviewRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (InterviewEntity is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Interview is not Found"
                            : "المقابلة غير موجودة";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    _Mapper.Map(Request, InterviewEntity, typeof(UpdateInterviewCommand), typeof(Interview));
                    
                    await _InterviewRepository.UpdateAsync(InterviewEntity);

                    await _InterviewNoteRepository.DeleteListAsync(InterviewNoteEntitiesToDelete);
                    await _InterviewQuestionRepository.DeleteListAsync(InterviewQuestionEntitiesToDelete);

                    IEnumerable<InterviewNote> NewInterviewNoteEntities = Request.InterviewNoteDtos
                        .Select(x => new InterviewNote()
                        {
                            ArabicNote = x.ArabicNote,
                            EnglishNote = x.EnglishNote,
                            InterviewId = Request.Id
                        });

                    await _InterviewNoteRepository.AddRangeAsync(InterviewNoteEntitiesToDelete);

                    IEnumerable<InterviewQuestion> NewInterviewQuestionEntities = Request.InterviewQuestionDtos
                        .Select(x => new InterviewQuestion()
                        {
                            ArabicQuestion = x.ArabicQuestion,
                            EnglishQuestion = x.EnglishQuestion,
                            InterviewId = Request.Id
                        });

                    await _InterviewQuestionRepository.AddRangeAsync(InterviewQuestionEntitiesToDelete);

                    List<InterviewUser> OldInterviewUserEntities = await _InterviewUserRepository
                        .Where(x => x.InterviewId == Request.Id)
                        .ToListAsync();

                    await _InterviewUserRepository.RemoveListAsync(OldInterviewUserEntities);

                    List<InterviewUser> NewInterviewUserEntities = Request.UsersInfo
                        .Select(x => new InterviewUser()
                        {
                            Name = x.Name,
                            Email = x.Email,
                            InterviewId = Request.Id
                        }).ToList();

                    await _InterviewUserRepository.AddRangeAsync(NewInterviewUserEntities);

                    List<InterviewCategory> OldInterviewCategoryEntities = await _InterviewCategoryRepository
                        .Where(x => x.InterviewId == Request.Id)
                        .ToListAsync();

                    await _InterviewCategoryRepository.RemoveListAsync(OldInterviewCategoryEntities);

                    List<InterviewCategory> NewInterviewCategoryEntities = Request.CategoriesIds
                        .Select(x => new InterviewCategory()
                        {
                            CategoryId = x,
                            InterviewId = Request.Id
                        }).ToList();

                    await _InterviewCategoryRepository.AddRangeAsync(NewInterviewCategoryEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل المقابلة بنجاح";

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
