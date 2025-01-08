using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetVirtualTableById
{
    public class GetVirtualTableByIdHandler 
        : IRequestHandler<GetVirtualTableByIdQuery, BaseResponse<GetVirtualTableByIdDto>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        private readonly IMapper _Mapper;
        public GetVirtualTableByIdHandler(IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository,
            IMapper Mapper)
        {
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetVirtualTableByIdDto>> Handle(GetVirtualTableByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSections = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.PrivateHashKey.Replace("/", "s1qa") == Request.PrivateHashKey.Replace("/", "s1qa"));

            if (VirtualTableForSections != null)
                return new BaseResponse<GetVirtualTableByIdDto>(ResponseMessage, true, 200, new GetVirtualTableByIdDto()
                {
                    Id = VirtualTableForSections.Id,
                    EnglishTitle = VirtualTableForSections.EnglishTitle,
                    ArabicTitle = VirtualTableForSections.ArabicTitle,
                    Title = Request.lang == "en"
                        ? VirtualTableForSections.EnglishTitle
                        : VirtualTableForSections.ArabicTitle
                });
            else
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table for section is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<GetVirtualTableByIdDto>(ResponseMessage, false, 404);
            }
        }
    }
}
