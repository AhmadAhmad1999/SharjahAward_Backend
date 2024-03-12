using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItemAttachment
{
    public class CreateCriterionItemAttachmentHandler : IRequestHandler<CreateCriterionItemAttachmentCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IFileService _AttachmentFileService;
        public CreateCriterionItemAttachmentHandler(IMapper Mapper,
            IAsyncRepository<CriterionItem> CriterionItemRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IFileService AttachmentFileService)
        {
            _Mapper = Mapper;
            _CriterionItemRepository = CriterionItemRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _AttachmentFileService = AttachmentFileService;
        }
        public async Task<BaseResponse<object>> Handle(CreateCriterionItemAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItem? CheckIfCriterionItemIdIsExist = await _CriterionItemRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CriterionItemId);

            if (CheckIfCriterionItemIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion item is Not Found"
                    : "البند المعياري غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            CriterionItemAttachment NewCriterionEntity = _Mapper.Map<CriterionItemAttachment>(Request);

            NewCriterionEntity.AttachementPath = await _AttachmentFileService.SaveFileAsync(Request.Attachment);

            await _CriterionItemAttachmentRepository.AddAsync(NewCriterionEntity);

            CreateCriterionItemAttachmentVM CreateCriterionItemAttachmentVM = _Mapper.Map<CreateCriterionItemAttachmentVM>(NewCriterionEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200, NewCriterionEntity);
        }
    }
}
