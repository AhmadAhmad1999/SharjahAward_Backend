using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Commands.CreateAdvancedFormBuilderSection
{
    public class CreateAdvancedFormBuilderSectionHandler : IRequestHandler<CreateAdvancedFormBuilderSectionCommand,
        BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        public CreateAdvancedFormBuilderSectionHandler(IMapper Mapper,
            IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository)
        {
            _Mapper = Mapper;
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateAdvancedFormBuilderSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderSection? CheckIfSectionNameIsAlreadyUsed = await _AdvancedFormBuilderSectionRepository
                .FirstOrDefaultAsync(x => x.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                    (x.ArabicName.ToLower() == Request.ArabicName.ToLower() || x.EnglishName.ToLower() == Request.EnglishName.ToLower()));

            if (CheckIfSectionNameIsAlreadyUsed is not null)
            {
                if (CheckIfSectionNameIsAlreadyUsed.ArabicName.ToLower() == Request.ArabicName.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This section arabic name is already used"
                        : "اسم هذا القسم باللغة العربية مستخدم مسبقاً";

                else if (CheckIfSectionNameIsAlreadyUsed.EnglishName.ToLower() == Request.EnglishName.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This section english name is already used"
                        : "اسم هذا القسم باللغة الإنكليزية مستخدم مسبقاً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            AdvancedFormBuilderSection NewAdvancedFormBuilderSectionEntity = _Mapper.Map<AdvancedFormBuilderSection>(Request);

            int CheckIfSesctionNameIsAlreadyUsed = await _AdvancedFormBuilderSectionRepository
                .Where(x => x.VirtualTableForSectionId == Request.VirtualTableForSectionId)
                .OrderBy(x => x.OrderId)
                .Select(x => x.OrderId)
                .LastOrDefaultAsync();

            NewAdvancedFormBuilderSectionEntity.OrderId = CheckIfSesctionNameIsAlreadyUsed++;

            await _AdvancedFormBuilderSectionRepository.AddAsync(NewAdvancedFormBuilderSectionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
