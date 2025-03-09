using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopAttachmentModel;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop
{
    public class CreateTrainingWorkshopsCommandHandler
        : IRequestHandler<CreateTrainingWorkshopsCommand , BaseResponse<int>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository;

        public CreateTrainingWorkshopsCommandHandler(IAsyncRepository<TrainingWorkshop> _TrainingWorkshopRepository,
            IAsyncRepository<TrainingWorkshopAttachment> _TrainingWorkshopAttachmentRepository,
            IAsyncRepository<Category> _CategoryRepository,
            IFileService _FileService,
            IMapper _Mapper,
            IAsyncRepository<TrainingWorkshopAttachmentType> _TrainingWorkshopAttachmentTypeRepository)
        {
            this._TrainingWorkshopRepository = _TrainingWorkshopRepository;
            this._TrainingWorkshopAttachmentRepository = _TrainingWorkshopAttachmentRepository;
            this._CategoryRepository = _CategoryRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._TrainingWorkshopAttachmentTypeRepository = _TrainingWorkshopAttachmentTypeRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateTrainingWorkshopsCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Category? CategoryEntity = await _CategoryRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

            if (CategoryEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Category is not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<int>(ResponseMessage, false, 404);
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
                    TrainingWorkshop NewTrainingWorkshopEntity = _Mapper.Map<TrainingWorkshop>(Request);

                    string ThumbnailPath = await _FileService.SaveFileAsync(Request.Thumbnail, 0);

                    NewTrainingWorkshopEntity.Thumbnail = ThumbnailPath;

                    TrainingWorkshop Response = await _TrainingWorkshopRepository.AddAsync(NewTrainingWorkshopEntity);

                    foreach (CreateTrainingWorkshopAttachmentsDto TrainingWorkshopAttachments in Request.TrainingWorkshopAttachments)
                    {
                        TrainingWorkshopAttachment NewTrainingWorkshopAttachmentEntity = new TrainingWorkshopAttachment()
                        {
                            EnglishName = TrainingWorkshopAttachments.EnglishName,
                            ArabicName = TrainingWorkshopAttachments.ArabicName,
                            AttachementPath = _FileService.SaveFileAsync(TrainingWorkshopAttachments.attachment, SystemFileType.Pdf).Result,
                            SizeOfAttachmentInKB = 0,
                            TrainingWorkshopId = Response.Id
                        };

                        await _TrainingWorkshopAttachmentRepository.AddAsync(NewTrainingWorkshopAttachmentEntity);

                        List<TrainingWorkshopAttachmentType> NewTrainingWorkshopAttachmentTypeEntities = TrainingWorkshopAttachments
                            .AttachmentType
                            .Select(x => new TrainingWorkshopAttachmentType()
                            {
                                AttachmentType = x,
                                TrainingWorkshopAttachmentId = NewTrainingWorkshopAttachmentEntity.Id
                            }).ToList();

                        await _TrainingWorkshopAttachmentTypeRepository.AddRangeAsync(NewTrainingWorkshopAttachmentTypeEntities);
                    }

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الورشة التدريبية بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<int>(ResponseMessage, true, 200, Response.Id);
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
