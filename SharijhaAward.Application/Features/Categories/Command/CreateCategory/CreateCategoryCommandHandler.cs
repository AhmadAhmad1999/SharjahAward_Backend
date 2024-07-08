using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandHandler
        : IRequestHandler<CreateCategoryCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<Cycle> cycleRepository,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository,
            IFileService fileService,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _cycleRepository = cycleRepository;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            string msg;
            if (request.CycleId != null)
            {
                var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);

                if (cycle == null)
                {
                    msg = request.lang == "en"
                        ? "Cycle not Found"
                        : "الدورة غير موجودة";

                    return new BaseResponse<object>(msg, false, 404);
                }
                if (cycle.Status == Domain.Constants.Common.Status.Close)
                {
                    msg = request.lang == "en"
                        ? "The Status of Cycle is Close"
                        : "حالة الدورة مغلقة";

                    return new BaseResponse<object>(msg, false, 400);
                }
            }
            else if (request.ParentId != null)
            {
                var ParentCategory = await _categoryRepository.GetByIdAsync(request.ParentId.Value);
                if (ParentCategory == null)
                {
                    msg = request.lang == "en"
                        ? "Parent Category not Found"
                        : "الفئة الرئيسية غير موجودة";

                    return new BaseResponse<object>(msg, false, 404);
                }
            }
            var category = _mapper.Map<Category>(request);

            category.Icon = await  _fileService.SaveFileAsync(request.Icon, SystemFileType.Icons);

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
                    await _categoryRepository.AddAsync(category);

                    if (request.RelatedToClasses != null
                            ? request.RelatedToClasses.Value
                            : false)
                    {
                        if (request.EducationalClasses != null
                                ? request.EducationalClasses.Count() > 0
                                : false)
                        {
                            IEnumerable<CategoryEducationalClass> CategoryEducationalClasses = request.EducationalClasses!
                                .Select(x => new CategoryEducationalClass()
                                {
                                    CategoryId = category.Id,
                                    EducationalClassId = x.EducationalClassId,
                                    NumberOfExpectedWinners = x.NumberOfExpectedWinners
                                });

                            await _CategoryEducationalClassRepository.AddRangeAsync(CategoryEducationalClasses);
                        }
                    }
                    if (request.RelatedToEducationalEntities != null
                        ? request.RelatedToEducationalEntities.Value
                        : false)
                    {
                        if (request.EducationalEntityIds != null
                            ? request.EducationalEntityIds.Any()
                            : false)
                        {
                            IEnumerable<CategoryEducationalEntity> NewCategoryEducationalEntityEntities = request.EducationalEntityIds!
                                .Select(x => new CategoryEducationalEntity()
                                {
                                    EducationalEntityId = x,
                                    CategoryId = category.Id
                                });

                            await _CategoryEducationalEntityRepository.AddRangeAsync(NewCategoryEducationalEntityEntities);
                        }
                    }
                    msg = request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الفئة بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(msg, true, 200, category.Id);
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
