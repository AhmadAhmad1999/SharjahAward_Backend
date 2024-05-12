using MediatR;
using SharijhaAward.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Commands.UpdateInstruction
{
    public class UpdateInstructionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        [MaxLength]
        public string Content { get; set; } = null!;
        public string? lang { get; set; }
    }
}
