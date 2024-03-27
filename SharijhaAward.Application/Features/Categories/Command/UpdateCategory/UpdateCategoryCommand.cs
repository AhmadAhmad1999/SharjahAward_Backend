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

namespace SharijhaAward.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool UpdateOnIcon { get; set; } = false;
        public IFormFile? Icon { get; set; } = null!;
        public CategoryClassification CategoryClassification { get; set; }
        public DateTime? SubscriberPortalClosingDate { get; set; }
        public DateTime? InitialArbitrationStartDate { get; set; }
        public DateTime? InitialArbitrationEndDate { get; set; }
        public DateTime? FinalArbitrationStartDate { get; set; }
        public DateTime? FinalArbitrationEndDate { get; set; }
        public int FinalArbitrationQualificationMark { get; set; }
        public int WinningScore { get; set; }
        public Status Status { get; set; } = Status.InActive;
        public bool RelatedToClasses { get; set; }
        public int ExpectedNumberOfWinners { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
