using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm
{
    public class CreateProvidedFormCommand : IRequest<Unit>
    {
        public required string Arabic_Name { get; set; }
        public required string English_Name { get; set; }
        public required string Male { get; set; }
        public required string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Identity_Number { get; set; } = string.Empty;
        public string EducationTypeName {  get; set; } = string.Empty;
        public Guid subscriberId { get; set; }
    }
}
