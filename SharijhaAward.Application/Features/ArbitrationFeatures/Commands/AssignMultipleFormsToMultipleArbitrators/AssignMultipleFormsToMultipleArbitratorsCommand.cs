using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AssignMultipleFormsToMultipleArbitrators
{
    public class AssignMultipleFormsToMultipleArbitratorsCommand : IRequest<BaseResponse<object>>
    {
        public List<int> ArbitratorsIds { get; set; } = new List<int>();
        public List<int> FormsIds { get; set; } = new List<int>();
        public bool Assign { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
