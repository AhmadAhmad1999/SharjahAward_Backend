using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.CategoryConstants;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Categories.Command.CreateCategory
{
    public class CreateCategoryCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public IFormFile Icon { get; set; } = null!;
        public CategoryClassification? CategoryClassification { get; set; }
        public float? FinalArbitrationQualificationMark { get; set; }
        public float? WinningScore { get; set; }
        public int? ExpectedNumberOfWinners { get; set; }
        public float? MinimumAmountToParticipateInTheAward { get; set; }
        public float? MinimumAmountToObtainACertificateOfParticipation { get; set; }
        public bool? RelatedToClasses { get; set; }
        public List<CreateCategoryEducationalClassDto>? EducationalClasses { get; set; }
        public int? ParentId { get; set; }
        public int? CycleId { get; set; }
        public string lang {  get; set; } = string.Empty;
    }
}
