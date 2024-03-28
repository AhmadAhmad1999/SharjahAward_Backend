using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator
{
    public class CreateCoordinatorCommand : IRequest<BaseResponse<Guid>>
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public EducationType EducationType { get; set; }
        public Emirates Emirates { get; set; }
        public IFormFile PersonalPhoto { get; set; } = null!;
        public string lang { get; set; } = string.Empty;
        public List<Guid> EducationalEntitiesIds { get; set; } = new List<Guid>();
        public List<Guid> EducationalInstitutionsIds { get; set; } = new List<Guid>();
        public List<AddDynamicAttributeValueMainCommand> DynamicAttributesWithValues { get; set; } = new List<AddDynamicAttributeValueMainCommand>();
        public string? WWWRootFilePath { get; set; }
    }
}
