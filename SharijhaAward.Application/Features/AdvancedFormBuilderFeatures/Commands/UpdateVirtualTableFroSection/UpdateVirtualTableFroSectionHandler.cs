using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateVirtualTableFroSection
{
    public class UpdateVirtualTableFroSectionHandler : IRequestHandler<UpdateVirtualTableFroSectionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<VirtualTableForSection> _UpdateVirtualTableFroSectionRepository;
        private readonly IMapper _Mapper;
        public UpdateVirtualTableFroSectionHandler(IMapper Mapper,
            IAsyncRepository<VirtualTableForSection> EducationalClassRepository)
        {
            _UpdateVirtualTableFroSectionRepository = EducationalClassRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateVirtualTableFroSectionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSectionEntityToUpdate = await _UpdateVirtualTableFroSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (VirtualTableForSectionEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table is not found"
                    : "الجدول الافتراضي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, VirtualTableForSectionEntityToUpdate, typeof(UpdateVirtualTableFroSectionCommand), typeof(VirtualTableForSection));

            await _UpdateVirtualTableFroSectionRepository.UpdateAsync(VirtualTableForSectionEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Virtual table has been updated successfully"
                : "تم تعديل الجدول الافتراضي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}