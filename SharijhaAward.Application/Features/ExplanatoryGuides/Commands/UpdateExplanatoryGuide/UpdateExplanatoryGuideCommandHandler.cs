using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.UpdateExplanatoryGuide
{
    public class UpdateExplanatoryGuideCommandHandler
        : IRequestHandler<UpdateExplanatoryGuideCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateExplanatoryGuideCommandHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository, IFileService fileService, IMapper mapper)
        {
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateExplanatoryGuideCommand request, CancellationToken cancellationToken)
        {
            var GuideToUpdate = await _explanatoryGuideRepository.GetByIdAsync(request.GuideId);
            string msg = request.lang == "en"
                ? "The Explanatory Guide has been Updated"
                : "تم تعديل الدليل التفسيري";

            if(GuideToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "The Explanatory Guide not found"
                    : "الدليل التفسيري غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, GuideToUpdate, typeof(UpdateExplanatoryGuideCommand), typeof(ExplanatoryGuide));
            
            if(request.UpdateOnEnglishFile)
                GuideToUpdate.EnglishFilePath = await _fileService.SaveFileAsync(request.EnglishFile!);
            
            if (request.UpdateOnArabicFile)
                GuideToUpdate.ArabicFilePath = await _fileService.SaveFileAsync(request.ArabicFile!);

            await _explanatoryGuideRepository.UpdateAsync(GuideToUpdate);

            return new BaseResponse<object>(msg,true, 200);
        }
    }
}
