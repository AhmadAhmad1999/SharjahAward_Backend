﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQs.Commands.CreateGeneralFAQ
{
    public class CreateGeneralFAQHandler : IRequestHandler<CreateGeneralFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestion> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public CreateGeneralFAQHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestion> GeneralFrequentlyAskedQuestionRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQRepository = GeneralFrequentlyAskedQuestionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateGeneralFAQCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFrequentlyAskedQuestion GeneralFAQEntity = _Mapper.Map<GeneralFrequentlyAskedQuestion>(Request);

            await _GeneralFAQRepository.AddAsync(GeneralFAQEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
