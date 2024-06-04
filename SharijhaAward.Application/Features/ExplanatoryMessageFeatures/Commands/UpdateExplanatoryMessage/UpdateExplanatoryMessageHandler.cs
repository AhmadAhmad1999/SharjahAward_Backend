using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Commands.UpdateExplanatoryMessage
{
    public class UpdateExplanatoryMessageHandler : IRequestHandler<UpdateExplanatoryMessageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExplanatoryMessage> _ExplanatoryMessageRepository;
        private readonly IMapper _Mapper;

        public UpdateExplanatoryMessageHandler(IMapper Mapper,
            IAsyncRepository<ExplanatoryMessage> ExplanatoryMessageRepository)
        {
            _ExplanatoryMessageRepository = ExplanatoryMessageRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateExplanatoryMessageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ExplanatoryMessage? ExplanatoryMessageEntityToUpdate = await _ExplanatoryMessageRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ExplanatoryMessageEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Explanatory message is not found"
                    : "الرسالة التوضيحية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ExplanatoryMessageEntityToUpdate, typeof(UpdateExplanatoryMessageCommand), typeof(ExplanatoryMessage));

            await _ExplanatoryMessageRepository.UpdateAsync(ExplanatoryMessageEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Explanatory message has been updated successfully"
                : "تم تعديل الرسالة التوضيحية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
