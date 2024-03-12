using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionAttachment
{
    public class CreateCriterionAttachmentHandler : IRequestHandler<CreateCriterionAttachmentCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IFileService _AttachmentFileService;

        public CreateCriterionAttachmentHandler(IMapper Mapper,
            IAsyncRepository<Criterion> CriterionRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IFileService AttachmentFileService)
        {
            _Mapper = Mapper;
            _CriterionRepository = CriterionRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _AttachmentFileService = AttachmentFileService;
        }
        public async Task<BaseResponse<object>> Handle(CreateCriterionAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CheckIfCriterionIdIsExist = await _CriterionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CriterionId);

            if (CheckIfCriterionIdIsExist == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion is Not Found"
                    : "المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            CriterionAttachment NewCriterionEntity = _Mapper.Map<CriterionAttachment>(Request);

            NewCriterionEntity.AttachementPath = await _AttachmentFileService.SaveFileAsync(Request.Attachment);

            await _CriterionAttachmentRepository.AddAsync(NewCriterionEntity);

            CreateCriterionAttachmentVM CreateCriterionAttachmentVM = _Mapper.Map<CreateCriterionAttachmentVM>(NewCriterionEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200, NewCriterionEntity);
        }
    }
}
