using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetArbitratrionDataByArbitratorId
{
    public class GetArbitratrionDataByArbitratorIdDto
    {
        public string ArbitratorName { get; set; } = null!;
        public int NumberOfAssignedForms { get; set; }
        public List<FormsListVMForArbitrationDto> AssignedForms { get; set; } = new List<FormsListVMForArbitrationDto>();
        public List<FormsListVMForArbitrationDto> RemainingForms { get; set; } = new List<FormsListVMForArbitrationDto>();
    }
}
