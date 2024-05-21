using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.UpdateChairmanNotesOnFinalArbitrationScore
{
    public class UpdateChairmanNotesOnFinalArbitrationScoreHandler
        : IRequestHandler<UpdateChairmanNotesOnFinalArbitrationScoreCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;
        private readonly IMapper _Mapper;

        public UpdateChairmanNotesOnFinalArbitrationScoreHandler(IMapper Mapper,
            IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository)
        {
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateChairmanNotesOnFinalArbitrationScoreCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnFinalArbitrationScore? ChairmanNotesOnFinalArbitrationScoreEntityToUpdate = await _ChairmanNotesOnFinalArbitrationScoreRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnFinalArbitrationScoreEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on final arbitration score is not found"
                    : "ملاحظة رئيس اللجنة على نتيجة التحكيم النهائي غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ChairmanNotesOnFinalArbitrationScoreEntityToUpdate, typeof(UpdateChairmanNotesOnFinalArbitrationScoreCommand), typeof(ChairmanNotesOnFinalArbitrationScore));

            await _ChairmanNotesOnFinalArbitrationScoreRepository.UpdateAsync(ChairmanNotesOnFinalArbitrationScoreEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Chairman note on final arbitration score has been updated successfully"
                : "تم تعديل ملاحظة رئيس اللجنة على نتيجة التحكيم النهائي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
