using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.GeneralFAQs.Commands.CreateGeneralFAQ;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Commands.CreateGeneralFAQCategory
{
    public class CreateGeneralFAQCategoryHandler : IRequestHandler<CreateGeneralFAQCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> _GeneralFAQCategoryRepository;
        private readonly IMapper _Mapper;

        public CreateGeneralFAQCategoryHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> GeneralFAQCategoryRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateGeneralFAQCategoryCommand Request, CancellationToken cancellationToken)
        {
            GeneralFrequentlyAskedQuestionCategory NewGeneralFAQCategoryEntity = _Mapper.Map<GeneralFrequentlyAskedQuestionCategory>(Request);

            await _GeneralFAQCategoryRepository.AddAsync(NewGeneralFAQCategoryEntity);

            return new BaseResponse<object>(string.Empty, true, 200);
        }
    }
}
