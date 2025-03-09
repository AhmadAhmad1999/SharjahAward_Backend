using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment
{
    public class UpdateExtraAttachmentCommandHandler
         : IRequestHandler<UpdateExtraAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository;

        public UpdateExtraAttachmentCommandHandler(IAsyncRepository<ExtraAttachment> _ExtraAttachmentRepository, 
            IMapper _Mapper,
            IAsyncRepository<ExtraAttachmentAttachmentType> _ExtraAttachmentAttachmentTypeRepository)
        {
            this._ExtraAttachmentRepository = _ExtraAttachmentRepository;
            this._Mapper = _Mapper;
            this._ExtraAttachmentAttachmentTypeRepository = _ExtraAttachmentAttachmentTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateExtraAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ExtraAttachment? ExtraAttachmentEntity = await _ExtraAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ExtraAttachmentEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Extra attachment is not found"
                    : "الملف الإضافي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ExtraAttachmentEntity, typeof(UpdateExtraAttachmentCommand), typeof(ExtraAttachment));

            List<ExtraAttachmentAttachmentType> ExtraAttachmentAttachmentTypeEntitiesToDelete = _ExtraAttachmentAttachmentTypeRepository
                .Where(x => x.ExtraAttachmentId == Request.Id)
                .ToList();

            List<ExtraAttachmentAttachmentType> NewExtraAttachmentAttachmentTypeEntities = Request.AttachmentType
                .Select(x => new ExtraAttachmentAttachmentType()
                {
                    AttachmentType = x,
                    ExtraAttachmentId = Request.Id
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
                    await _ExtraAttachmentRepository.UpdateAsync(ExtraAttachmentEntity);

                    if (ExtraAttachmentAttachmentTypeEntitiesToDelete.Any())
                        await _ExtraAttachmentAttachmentTypeRepository.DeleteListAsync(ExtraAttachmentAttachmentTypeEntitiesToDelete);

                    if (NewExtraAttachmentAttachmentTypeEntities.Any())
                        await _ExtraAttachmentAttachmentTypeRepository.AddRangeAsync(NewExtraAttachmentAttachmentTypeEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Extra Attachment has been Updated"
                        : "تم تعديل الملف الإضافي";

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
