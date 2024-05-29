using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateVirtualTableFroSection
{
    public class CreateVirtualTableForSectionHandler : IRequestHandler<CreateVirtualTableFroSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;

        public CreateVirtualTableForSectionHandler(IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository)
        {
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateVirtualTableFroSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection NewVirtualTableForSectionEntity = new VirtualTableForSection()
            {
                ArabicTitle = Request.ArabicTitle,
                EnglishTitle = Request.EnglishTitle
            };

            await _VirtualTableForSectionRepository.AddAsync(NewVirtualTableForSectionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200, NewVirtualTableForSectionEntity.Id);
        }
    }
}
