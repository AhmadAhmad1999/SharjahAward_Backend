using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetInputedAdvancedFormsByVirtualTableId
{
    public class GetInputedAdvancedFormsByVirtualTableIdHandler 
        : IRequestHandler<GetInputedAdvancedFormsByVirtualTableIdQuery, BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        public GetInputedAdvancedFormsByVirtualTableIdHandler(IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository,
            IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository)
        {
            this._AdvancedFormBuilderRepository = _AdvancedFormBuilderRepository;
            this._AdvancedFormBuilderSectionRepository = _AdvancedFormBuilderSectionRepository;
            this._AdvancedFormBuilderValueRepository = _AdvancedFormBuilderValueRepository;
            this._VirtualTableForSectionRepository = _VirtualTableForSectionRepository;
        }

        public async Task<BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto>>
            Handle(GetInputedAdvancedFormsByVirtualTableIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.VirtualTableForSectionId);

            if (VirtualTableForSectionEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table for section is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto>(ResponseMessage, false, 404);
            }

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => x.AdvancedFormBuilderSection!.VirtualTableForSectionId == Request.VirtualTableForSectionId &&
                    x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                    x.ViewInTable)
                .ToListAsync();

            // Assuming ColumnsNames should be a dictionary
            Dictionary<string, Tuple<object, string>> ColumnsDictionary = AdvancedFormBuilderEntities
                .ToDictionary(
                    Entity => Entity.EnglishLabel,
                    Entity => Tuple.Create((object)Entity.ArabicLabel, Entity.AttributeDataType!.Name));

            ColumnsDictionary.Add("VirtualTableId", Tuple.Create((object)"المعرف الافتراضي", "Number"));

            object? Values = _AdvancedFormBuilderValueRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Contains(x.AdvancedFormBuilderId) &&
                    x.VirtualTableId == Request.VirtualTableId)
                .GroupBy(x => x.VirtualTableId)
                .AsEnumerable()
                .Select(AdvancedFormBuilderValueEntity => AdvancedFormBuilderValueEntity
                    .ToDictionary(
                        Entity => Entity.AdvancedFormBuilder!.EnglishLabel,
                        Entity => (object)Entity.Value))
                .FirstOrDefault<object>();

            GetInputedAdvancedFormsByVirtualTableIdDto Response = new GetInputedAdvancedFormsByVirtualTableIdDto()
            {
                ColumnsNames = ColumnsDictionary.Select(kvp => new { kvp.Key, Label = kvp.Value.Item1, Type = kvp.Value.Item2 }).Cast<object>().ToList(),
                Values = Values != null ? Values : new object()
            };

            return new BaseResponse<GetInputedAdvancedFormsByVirtualTableIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
