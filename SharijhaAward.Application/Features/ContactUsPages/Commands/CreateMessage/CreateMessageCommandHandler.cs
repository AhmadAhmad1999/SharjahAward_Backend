using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class CreateMessageCommandHandler
        : IRequestHandler<CreateMessageCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<EmailMessage> _messageRepository;
        private readonly IMapper _mapper;
        public async Task<BaseResponse<Guid>> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = _mapper.Map<EmailMessage>(request);
            message.IsRead = false;
            message.Status = Domain.Constants.ContactUsConstants.MessageStatus.New;
            var data = await _messageRepository.AddAsync(message);

            return new BaseResponse<Guid>("", true, 200, data.Id);
        }
    }
}
