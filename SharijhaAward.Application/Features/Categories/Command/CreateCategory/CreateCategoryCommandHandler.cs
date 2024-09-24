using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommandHandler
        : IRequestHandler<CreateCategoryCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<Cycle> cycleRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IFileService fileService,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _cycleRepository = cycleRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            string msg;

            if (request.RelatedToClasses == null && (request.EducationalClasses != null ? request.EducationalClasses.Any() : false))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"null\" then " +
                        "you can't select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"بدون قيمة\" فلن تتمكن من تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }
            else if ((request.RelatedToClasses != null ? request.RelatedToClasses.Value : false) &&
                (request.EducationalClasses == null ? true : !request.EducationalClasses.Any()))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"true\" then " +
                        "you have to select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"صحيح\"، فيجب عليك تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }
            else if ((request.RelatedToClasses != null ? !request.RelatedToClasses.Value : false) &&
                    (request.EducationalClasses != null ? request.EducationalClasses.Any() : false))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"false\" then " +
                        "you can't select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"خطأ\"، فلن تتمكن من تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }

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
                var ParentCategory = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.ParentId.Value);
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
