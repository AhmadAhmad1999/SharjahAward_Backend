using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.AssignUserToCategories
{
    public class AssignUserToCategoriesCommand : IRequest<BaseResponse<object>>
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public List<int> CategoriesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
