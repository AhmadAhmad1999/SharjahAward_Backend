using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment
{
    public class CreateWorkshopeAttachmentCommandHandler
        : IRequestHandler<CreateWorkshopeAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;

        public CreateWorkshopeAttachmentCommandHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository, 
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository,
            IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository,
            IFileService _FileService, 
            IMapper _Mapper)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._TrainingWorkshopAttachmentTypeRepository = _TrainingWorkshopAttachmentTypeRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateWorkshopeAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TrainingWorkshop? TrainingWorkshopEntity = await _TrainingWorkshopRepository
                .FirstOrDefaultAsync(x => x.Id == Request.WorkshopeId);

            if (TrainingWorkshopEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Training workshop is not found"
                    : "الورشة التدريبية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    TrainingWorkshopAttachment NewTrainingWorkshopAttachmentEntity = _Mapper.Map<TrainingWorkshopAttachment>(Request);
                    NewTrainingWorkshopAttachmentEntity.AttachementPath = await _FileService.SaveFileAsync(Request.attachment, SystemFileType.Pdf);
                    await _TrainingWorkshopAttachmentRepository.AddAsync(NewTrainingWorkshopAttachmentEntity);

                    List<TrainingWorkshopAttachmentType> NewTrainingWorkshopAttachmentTypeEntities = Request.AttachmentType
                        .Select(x => new TrainingWorkshopAttachmentType()
                        {
                            AttachmentType = x,
                            TrainingWorkshopAttachmentId = NewTrainingWorkshopAttachmentEntity.Id
                        }).ToList();

                    await _TrainingWorkshopAttachmentTypeRepository.AddRangeAsync(NewTrainingWorkshopAttachmentTypeEntities);

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
