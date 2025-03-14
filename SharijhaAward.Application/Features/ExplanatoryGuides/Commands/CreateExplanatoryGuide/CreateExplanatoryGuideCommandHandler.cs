﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.CreateExplanatoryGuide
{
    public class CreateExplanatoryGuideCommandHandler 
        : IRequestHandler<CreateExplanatoryGuideCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IFileService _attachmentFileService;
        private readonly IMapper _mapper;

        public CreateExplanatoryGuideCommandHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository, IAsyncRepository<Category> categoryRepository, IFileService attachmentFileService, IMapper mapper)
        {
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _categoryRepository = categoryRepository;
            _attachmentFileService = attachmentFileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateExplanatoryGuideCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "The Explanatory has been Added"
                : "تم إضافة الدليل التفسيري";

            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.CategoryId);
            if(category == null)
            {
                msg = request.lang == "en"
                ? "The Explanatory Not found"
                : " الدليل التفسيري غير موجود ";

                return new BaseResponse<object>(msg, false, 404);
            }
            var data = _mapper.Map<ExplanatoryGuide>(request);
            data.ArabicFilePath = await _attachmentFileService.SaveFileAsync(request.ArabicFile, SystemFileType.ExplanatoryGuide);
            data.EnglishFilePath = await _attachmentFileService.SaveFileAsync(request.EnglishFile, SystemFileType.ExplanatoryGuide);
            
            await _explanatoryGuideRepository.AddAsync(data);

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
