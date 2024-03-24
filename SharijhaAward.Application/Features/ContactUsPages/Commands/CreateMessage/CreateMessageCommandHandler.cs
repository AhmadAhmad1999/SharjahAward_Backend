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
        private readonly IAsyncRepository<Message> _messageRepository;
        private readonly IMapper _mapper;
        public Task<BaseResponse<Guid>> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
