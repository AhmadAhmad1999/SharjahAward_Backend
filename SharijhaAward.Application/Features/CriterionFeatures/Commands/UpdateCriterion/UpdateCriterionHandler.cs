using AutoMapper;
using MediatR;
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

            Criterion? MainCriterionEntityToUpdate = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (MainCriterionEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Main criterion is not found"
                    : "المعيار الرئيسي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, MainCriterionEntityToUpdate, typeof(UpdateCriterionCommand), typeof(Criterion));

            await _CriterionRepository.UpdateAsync(MainCriterionEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Main criterion has been updated successfully"
                : "تم تعديل المعيار الرئيسي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
