using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm
{
    public class CreateProvidedFormCommand : IRequest<BaseResponse<int>>
    {
        public int categoryId {  get; set; }
        public int? CategoryEducationalClassId {  get; set; }
        public string Formlanguage { get; set; } = string.Empty;
        public string lang {  get; set; } =string.Empty;
        public string token {  get; set; } = string.Empty;
    }
}
