using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetInitalQuestions;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetInitialQuestions
{
    public class GetInitialQuestionsQueryHandler
        : IRequestHandler<GetInitialQuestionsQuery, BaseResponse<List<InitialQuestionDto>>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;
        private readonly IMapper _mapper;

        public GetInitialQuestionsQueryHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository, IMapper mapper)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<InitialQuestionDto>>> Handle(GetInitialQuestionsQuery request, CancellationToken cancellationToken)
        {
            var Questions = await _chatBotQuestionRepository
                .Where(q => q.Initial)
                .Select(q => new InitialQuestionDto()
                {
                    Id = q.Id,
                    Question = request.lang == "en" ? q.EnglishQuestion : q.ArabicQuestion
                }).ToListAsync();

            return new BaseResponse<List<InitialQuestionDto>>("", true, 200, Questions);

        }
    }
}
