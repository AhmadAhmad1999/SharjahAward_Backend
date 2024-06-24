using MediatR;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeForNewRow
{
    public class AddDynamicAttributeForNewRowHandler : IRequestHandler<AddDynamicAttributeForNewRowCommand,
        BaseResponse<List<AddDynamicAttributeTableValueForSaveMainCommand>>>
    {
        public async Task<BaseResponse<List<AddDynamicAttributeTableValueForSaveMainCommand>>> 
            Handle(AddDynamicAttributeForNewRowCommand Request, CancellationToken cancellationToken)
        {
            List<AddDynamicAttributeTableValueForSaveMainCommand> LastRowId = Request.DynamicAttributesWithTableValues
                .GroupBy(x => x.RowId)
                .OrderByDescending(x => x.Key)
                .FirstOrDefault() ? .ToList() ?? new List<AddDynamicAttributeTableValueForSaveMainCommand>();

            if (LastRowId.Any())
            {
                List<AddDynamicAttributeTableValueForSaveMainCommand> NewListToAddToResponse = LastRowId
                    .Select(x => new AddDynamicAttributeTableValueForSaveMainCommand()
                    {
                        DynamicAttributeId = x.DynamicAttributeId,
                        ValueAsBinaryFile = null,
                        ValueAsString = null,
                        RowId = x.RowId + 1
                    }).ToList();

                Request.DynamicAttributesWithTableValues.AddRange(NewListToAddToResponse);

                return new BaseResponse<List<AddDynamicAttributeTableValueForSaveMainCommand>>
                    (string.Empty, true, 200, Request.DynamicAttributesWithTableValues);
            }

            return new BaseResponse<List<AddDynamicAttributeTableValueForSaveMainCommand>>(string.Empty, false, 200);
        }
    }
}
