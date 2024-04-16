﻿using AutoMapper;
using MediatR;
using Microsoft.CodeAnalysis.CSharp;
using Org.BouncyCastle.Bcpg;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage
{
    public class CreateMessageCommandHandler
        : IRequestHandler<CreateMessageCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<EmailMessage> _messageRepository;
        private readonly IAsyncRepository<EmailAttachment> _attachmentRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public CreateMessageCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IAsyncRepository<EmailMessage> messageRepository, IAsyncRepository<EmailAttachment> attachmentRepository, IFileService fileService, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _attachmentRepository = attachmentRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = _mapper.Map<EmailMessage>(request);
            message.IsRead = false;
            message.Status = Domain.Constants.ContactUsConstants.MessageStatus.New;
            if(request.token != null)
            {
                var UserId = _jwtProvider.GetUserIdFromToken(request.token);
                var User = await _userRepository.FirstOrDefaultAsync(u => u.Id == int.Parse(UserId));
                if(User == null)
                {
                    return new BaseResponse<int>("Un Auth", false, 401);
                }
                message.From = User!.Email;
            }
            var data = await _messageRepository.AddAsync(message);

            if (request.Attachments!.Count() > 0)
            {
                foreach(var attachment in request.Attachments!)
                {
                    EmailAttachment emailAttachment = new EmailAttachment()
                    {
                        AttachmentUrl = await _fileService.SaveFileAsync(attachment),
                        MessageId = data.Id
                    };    
                    
                    await _attachmentRepository.AddAsync(emailAttachment);
                }
            }
            
            return new BaseResponse<int>("", true, 200, data.Id);
        }
    }
}
