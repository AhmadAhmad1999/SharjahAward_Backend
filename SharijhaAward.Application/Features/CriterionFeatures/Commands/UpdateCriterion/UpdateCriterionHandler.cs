using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterion
{
    public class UpdateCriterionHandler : IRequestHandler<UpdateCriterionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IMapper _Mapper;
        public UpdateCriterionHandler(IMapper Mapper,
            IAsyncRepository<Criterion> CriterionRepository)
        {
            _CriterionRepository = CriterionRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateCriterionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CriterionEntityToUpdate = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion is not found"
                    : "المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (CriterionEntityToUpdate.ParentId is null)
            {
                Criterion? CheckIfMainCriterionIdDoesExist = await _CriterionRepository
                    .FirstOrDefaultAsync(x => x.Id == CriterionEntityToUpdate.ParentId && x.ParentId == null);

                if (CheckIfMainCriterionIdDoesExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Main criterion is not found"
                        : "المعيار الرئيسي غير موجود";

                    return new BaseResponse<object>(ResponseMessage, false, 404);
                }

                int OldTotalScoreForMainCategory = _CriterionRepository
                    .Where(x => x.ParentId != null 
                        ? (x.ParentId == CheckIfMainCriterionIdDoesExist.Id && x.Id != Request.Id)
                        : false)
                    .Select(x => x.Score).Sum();

                if (OldTotalScoreForMainCategory + Request.Score > CheckIfMainCriterionIdDoesExist.Score)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"The maximum score of this main criterion : {CheckIfMainCriterionIdDoesExist.EnglishTitle} cannot be exceeded"
                        : $"لا يمكن تجاوز العلامة العظمى للمعيار الرئيسي: {CheckIfMainCriterionIdDoesExist.ArabicTitle}";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            _Mapper.Map(Request, CriterionEntityToUpdate, typeof(UpdateCriterionCommand), typeof(Criterion));

            await _CriterionRepository.UpdateAsync(CriterionEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Criterion has been updated successfully"
                : "تم تعديل المعيار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
