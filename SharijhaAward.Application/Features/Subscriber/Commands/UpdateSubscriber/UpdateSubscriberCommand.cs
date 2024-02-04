using MediatR;
using SharijhaAward.Domain.Constants.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Subscriber.Commands.UpdateSubscriber
{
    public class UpdateSubscriberCommand : IRequest<Unit>
    {
        public Status Status { get; set; }
        public string IdentityNumber { get; set; } = string.Empty;
    }
}
