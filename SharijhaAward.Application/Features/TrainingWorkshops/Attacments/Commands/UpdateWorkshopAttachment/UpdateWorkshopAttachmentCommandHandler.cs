using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment
{
    public class UpdateWorkshopAttachmentCommandHandler
        : IRequestHandler<UpdateWorkshopAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository;

        public UpdateWorkshopAttachmentCommandHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository, 
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository, 
            IFileService _FileService, 
            IMapper _Mapper,
            IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._TrainingWorkshopAttachmentTypeRepository = _TrainingWorkshopAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateWorkshopAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TrainingWorkshopAttachment? TrainingWorkshopAttachmentEntity = await _TrainingWorkshopAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);
            
            if (TrainingWorkshopAttachmentEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                   ? "Training workshop attachment is not found"
                   : "الملف المطلوب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            string AttachementPath = TrainingWorkshopAttachmentEntity.AttachementPath;

            _Mapper.Map(Request, TrainingWorkshopAttachmentEntity, typeof(UpdateWorkshopAttachmentCommand), typeof(TrainingWorkshopAttachment));
    
            if (Request.EditOnAttachment && Request.attachment is not null)
                TrainingWorkshopAttachmentEntity.AttachementPath = await _FileService.SaveFileAsync(Request.attachment, SystemFileType.Pdf);

            else
                TrainingWorkshopAttachmentEntity.AttachementPath = AttachementPath;

            List<TrainingWorkshopAttachmentType> TrainingWorkshopAttachmentTypeEntitiesToDelete = _TrainingWorkshopAttachmentTypeRepository
                .Where(x => x.TrainingWorkshopAttachmentId == Request.Id)
                .ToList();

            List<TrainingWorkshopAttachmentType> NewTrainingWorkshopAttachmentTypeEntities = Request.AttachmentType
                .Select(x => new TrainingWorkshopAttachmentType()
                {
                    AttachmentType = x,
                    TrainingWorkshopAttachmentId = Request.Id
                }).ToList();

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
                    await _TrainingWorkshopAttachmentRepository.UpdateAsync(TrainingWorkshopAttachmentEntity);

                    if (TrainingWorkshopAttachmentTypeEntitiesToDelete.Any())
                        await _TrainingWorkshopAttachmentTypeRepository.DeleteListAsync(TrainingWorkshopAttachmentTypeEntitiesToDelete);

                    if (NewTrainingWorkshopAttachmentTypeEntities.Any())
                        await _TrainingWorkshopAttachmentTypeRepository.AddRangeAsync(NewTrainingWorkshopAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                         ? "Attachment has been updated"
                         : "تم تعديل الملف";

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
