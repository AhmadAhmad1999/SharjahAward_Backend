using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;

namespace SharijhaAward.Application.Features.ExplanatoryMessageFeatures.Queries.GetExplanatoryMessageById
{
    public class GetExplanatoryMessageByIdHandler 
        : IRequestHandler<GetExplanatoryMessageByIdQuery, BaseResponse<GetExplanatoryMessageByIdDto>>
    {
        private readonly IAsyncRepository<ExplanatoryMessage> _ExplanatoryMessageRepository;
        private readonly IMapper _Mapper;
        public GetExplanatoryMessageByIdHandler(IAsyncRepository<ExplanatoryMessage> ExplanatoryMessageRepository,
            IMapper Mapper)
        {
            _ExplanatoryMessageRepository = ExplanatoryMessageRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetExplanatoryMessageByIdDto>> 
            Handle(GetExplanatoryMessageByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.Id is not null)
            {
                ExplanatoryMessage? ExplanatoryMessageEntity = await _ExplanatoryMessageRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.Id);

                if (ExplanatoryMessageEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Explanatory message is not Found"
                        : "الرسالة التوضيحية غير موجودة";

                    return new BaseResponse<GetExplanatoryMessageByIdDto>(ResponseMessage, false, 404);
                }

                GetExplanatoryMessageByIdDto GetClassByIdDto = _Mapper.Map<GetExplanatoryMessageByIdDto>(ExplanatoryMessageEntity);

                return new BaseResponse<GetExplanatoryMessageByIdDto>(ResponseMessage, true, 200, GetClassByIdDto);
            }
            else if (Request.Type is not null)
            {
                ExplanatoryMessage? ExplanatoryMessageEntity = await _ExplanatoryMessageRepository
                    .FirstOrDefaultAsync(x => x.Type == Request.Type);

                if (ExplanatoryMessageEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Explanatory message is not Found"
                        : "الرسالة التوضيحية غير موجودة";

                    return new BaseResponse<GetExplanatoryMessageByIdDto>(ResponseMessage, false, 404);
                }

                GetExplanatoryMessageByIdDto GetClassByIdDto = _Mapper.Map<GetExplanatoryMessageByIdDto>(ExplanatoryMessageEntity);

                return new BaseResponse<GetExplanatoryMessageByIdDto>(ResponseMessage, true, 200, GetClassByIdDto);
            }

            return new BaseResponse<GetExplanatoryMessageByIdDto>(ResponseMessage, false, 400);
        }
    }
}
