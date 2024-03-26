﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralWorkshopsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Commands.UpdateGeneralWorkshop
{
    public class UpdateGeneralWorkshopCommandHandler
        : IRequestHandler<UpdateGeneralWorkshopCommand, BaseResponse<Guid>>
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

        public async Task<BaseResponse<Guid>> Handle(UpdateGeneralWorkshopCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Workshop has been Updated"
                : "تم تعديل الورشة التدريبية";

            var WorkshopToUpdate = await _generalWorkshopRepository.GetByIdAsync(request.Id);
           
            if(WorkshopToUpdate == null)
            {
                return new BaseResponse<Guid>("", false, 404);
            }
            var Workshop = WorkshopToUpdate;
            _mapper.Map(request, WorkshopToUpdate, typeof(UpdateGeneralWorkshopCommand), typeof(GeneralWorkshop));

            if (request.UpdateThumbnale)
                WorkshopToUpdate.Thumbnale = await _fileService.SaveFileAsync(request.Thumbnale);
            else
                WorkshopToUpdate.Thumbnale = Workshop.Thumbnale;

            if (request.UpdateVideo)
                WorkshopToUpdate.Video = await _fileService.SaveFileAsync(request.Video!);
            else
                WorkshopToUpdate.Video = Workshop.Video;

            if (request.UpdateAgendaImage)
                WorkshopToUpdate.AgendaImage = await _fileService.SaveFileAsync(request.AgendaImage!);
            else
                WorkshopToUpdate.AgendaImage = Workshop.AgendaImage;

             await _generalWorkshopRepository.UpdateAsync(WorkshopToUpdate);

            return new BaseResponse<Guid>(msg, true, 200);
           
        }
    }
}
