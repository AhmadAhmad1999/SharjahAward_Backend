using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Commands.UpdateGeneralFAQCategory
{
    public class UpdateGeneralFAQCategoryHandler : IRequestHandler<UpdateGeneralFAQCategoryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> _GeneralFAQCategoryRepository;
        private readonly IMapper _Mapper;

        public UpdateGeneralFAQCategoryHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> GeneralFAQCategoryRepository)
        {
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateGeneralFAQCategoryCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFrequentlyAskedQuestionCategory? GeneralFAQCategoryEntityToUpdate = await _GeneralFAQCategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQCategoryEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ category is not found"
                    : "فئة السؤال الشائع العام غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, GeneralFAQCategoryEntityToUpdate, typeof(UpdateGeneralFAQCategoryCommand), typeof(GeneralFrequentlyAskedQuestionCategory));

            await _GeneralFAQCategoryRepository.UpdateAsync(GeneralFAQCategoryEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "General FAQ category has been updated successfully"
                : "تم تعديل فئة السؤال الشائع العام بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
