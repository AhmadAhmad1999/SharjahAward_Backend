using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ChatBotModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ChatBotQuestions.Commands.DeleteChatBotQuestion
{
    public class DeleteChatBotQuestionCommandHandler
        : IRequestHandler<DeleteChatBotQuestionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChatBotQuestion> _chatBotQuestionRepository;

        public DeleteChatBotQuestionCommandHandler(IAsyncRepository<ChatBotQuestion> chatBotQuestionRepository)
        {
            _chatBotQuestionRepository = chatBotQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteChatBotQuestionCommand request, CancellationToken cancellationToken)
        {
            var question = await _chatBotQuestionRepository.GetByIdAsync(request.Id);
            
            if(question == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            await _chatBotQuestionRepository.DeleteAsync(question);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
