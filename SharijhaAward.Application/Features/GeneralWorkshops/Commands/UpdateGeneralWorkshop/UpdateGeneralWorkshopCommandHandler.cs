﻿using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.UpdateGeneralWorkshop
{
    public class UpdateGeneralWorkshopCommandHandler
        : IRequestHandler<UpdateGeneralWorkshopCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<GeneralWorkshop> _generalWorkshopRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateGeneralWorkshopCommandHandler(IAsyncRepository<GeneralWorkshop> generalWorkshopRepository, IFileService fileService, IMapper mapper)
        {
            _generalWorkshopRepository = generalWorkshopRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(UpdateGeneralWorkshopCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Workshop has been Updated"
                : "تم تعديل الورشة التدريبية";

            var WorkshopToUpdate = await _generalWorkshopRepository.GetByIdAsync(request.Id);
           
            if(WorkshopToUpdate == null)
            {
                return new BaseResponse<int>("", false, 404);
            }
            var Workshop = WorkshopToUpdate;

            string OldThumbnale = WorkshopToUpdate.Thumbnale;
            string? OldVideo = WorkshopToUpdate.Video;
            string? OldAgendaImage = WorkshopToUpdate.AgendaImage;

            _mapper.Map(request, WorkshopToUpdate, typeof(UpdateGeneralWorkshopCommand), typeof(GeneralWorkshop));

            if (request.UpdateThumbnale && request.Thumbnale != null)
                WorkshopToUpdate.Thumbnale = await _fileService.SaveFileAsync(request.Thumbnale, SystemFileType.Images);
            else
                WorkshopToUpdate.Thumbnale = OldThumbnale;

            if (request.UpdateVideo && request.Video != null)
                WorkshopToUpdate.Video = await _fileService.SaveFileAsync(request.Video!, SystemFileType.Videos);
            else
                WorkshopToUpdate.Video = OldVideo;

            if (request.UpdateAgendaImage)
                WorkshopToUpdate.AgendaImage = await _fileService.SaveFileAsync(request.AgendaImage!, SystemFileType.Images);
            else
                WorkshopToUpdate.AgendaImage = OldAgendaImage;

            await _generalWorkshopRepository.UpdateAsync(WorkshopToUpdate);

            return new BaseResponse<int>(msg, true, 200);
           
        }
    }
}
