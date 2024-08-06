using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Coordinators.Commands.UpdateCoordinator
{
    public class UpdateCoordinatorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string arabicName { get; set; } = string.Empty;
        public string englishName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
        public EducationType educationType { get; set; }
        public Emirates emirates { get; set; }
        public bool updateOnPersonalPhoto {  get; set; }
        public IFormFile? personalPhoto { get; set; } = null!;
        public string? lang { get; set; }
        public string? WWWRootFilePath { get; set; }
        public List<int> EducationalEntitiesIds { get; set; } = new List<int>();
      
    }
}
