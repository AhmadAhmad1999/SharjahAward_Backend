using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop
{
    public class UpdateTrainingWorkshopCommandHandler 
        : IRequestHandler<UpdateTrainingWorkshopCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;

        public UpdateTrainingWorkshopCommandHandler(IFileService _FileService,
            IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository,
            IMapper _Mapper)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTrainingWorkshopCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TrainingWorkshop? TrainingWorkshopEntity = await _TrainingWorkshopRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

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
                    string OldThumbnailValue = TrainingWorkshopEntity.Thumbnail;
                    _Mapper.Map(Request, TrainingWorkshopEntity, typeof(UpdateTrainingWorkshopCommand), typeof(TrainingWorkshop));

                    if (Request.EditeOnThumbnail)
                        TrainingWorkshopEntity.Thumbnail = await _FileService.SaveFileAsync(Request.Thumbnail!, SystemFileType.Images);
                    else
                        TrainingWorkshopEntity.Thumbnail = OldThumbnailValue;

                    await _TrainingWorkshopRepository.UpdateAsync(TrainingWorkshopEntity);

                    if (Request.TrainingWorkshopAttachmentsToDelete.Any())
                    {
                        List<TrainingWorkshopAttachment> TrainingWorkshopAttachmentEntitiesToDelete = _TrainingWorkshopAttachmentRepository
                            .Where(x => Request.TrainingWorkshopAttachmentsToDelete.Any(y => y == x.Id))
                            .ToList();

                        await _TrainingWorkshopAttachmentRepository.DeleteListAsync(TrainingWorkshopAttachmentEntitiesToDelete);
                    }

                    if (Request.TrainingWorkshopAttachmentsToUpdate.Any())
                    {
                        List<TrainingWorkshopAttachment> TrainingWorkshopAttachmentEntitiesToUpdate = _TrainingWorkshopAttachmentRepository
                            .Where(x => Request.TrainingWorkshopAttachmentsToUpdate.Select(x => x.Id).Contains(x.Id))
                            .ToList();

                        foreach (TrainingWorkshopAttachment TrainingWorkshopAttachmentEntityToUpdate in TrainingWorkshopAttachmentEntitiesToUpdate)
                        {
                            string AttachementPath = TrainingWorkshopAttachmentEntityToUpdate.AttachementPath;

                            UpdateWorkshopAttachmentCommand UpdateWorkshopAttachmentCommand = Request.TrainingWorkshopAttachmentsToUpdate
                                .FirstOrDefault(x => x.Id == TrainingWorkshopAttachmentEntityToUpdate.Id)!;

                            _Mapper.Map(UpdateWorkshopAttachmentCommand, TrainingWorkshopAttachmentEntityToUpdate,
                                typeof(UpdateWorkshopAttachmentCommand), typeof(TrainingWorkshopAttachment));

                            if (UpdateWorkshopAttachmentCommand.EditOnAttachment)
                                TrainingWorkshopAttachmentEntityToUpdate.AttachementPath = await _FileService.SaveFileAsync(UpdateWorkshopAttachmentCommand.attachment!, SystemFileType.Pdf);

                            else
                                TrainingWorkshopAttachmentEntityToUpdate.AttachementPath = AttachementPath;

                            await _TrainingWorkshopAttachmentRepository.UpdateAsync(TrainingWorkshopAttachmentEntityToUpdate);
                        }
                    }

                    if (Request.TrainingWorkshopAttachmentsToAdd.Any())
                    {
                        IEnumerable<TrainingWorkshopAttachment> NewTrainingWorkshopAttachmentEntities = Request.TrainingWorkshopAttachmentsToAdd
                            .Select(x => new TrainingWorkshopAttachment()
                            {
                                EnglishName = x.EnglishName,
                                ArabicName = x.ArabicName,
                                AttachementPath = _FileService.SaveFileAsync(x.attachment, SystemFileType.Pdf).Result,
                                SizeOfAttachmentInKB = 0,
                                AttachmentType = x.AttachmentType,
                                TrainingWorkshopId = TrainingWorkshopEntity.Id
                            });

                        await _TrainingWorkshopAttachmentRepository.AddRangeAsync(NewTrainingWorkshopAttachmentEntities);
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Workshop has been Updated"
                        : "تم تعديل الورشة التدريبية"; ;

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
