using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.UpdateChairmanNotesOnInitialArbitration
{
    public class UpdateChairmanNotesOnInitialArbitrationHandler
        : IRequestHandler<UpdateChairmanNotesOnInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        private readonly IMapper _Mapper;

        public UpdateChairmanNotesOnInitialArbitrationHandler(IMapper Mapper,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateChairmanNotesOnInitialArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnInitialArbitration? ChairmanNotesOnInitialArbitrationEntityToUpdate = await _ChairmanNotesOnInitialArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnInitialArbitrationEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on initial arbitration is not found"
                    : "ملاحظة رئيس اللجنة على التحكيم الأولي غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ChairmanNotesOnInitialArbitrationEntityToUpdate, typeof(UpdateChairmanNotesOnInitialArbitrationCommand), typeof(ChairmanNotesOnInitialArbitration));

            await _ChairmanNotesOnInitialArbitrationRepository.UpdateAsync(ChairmanNotesOnInitialArbitrationEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Chairman note on initial arbitration has been updated successfully"
                : "تم تعديل ملاحظة رئيس اللجنة على التحكيم الأولي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
