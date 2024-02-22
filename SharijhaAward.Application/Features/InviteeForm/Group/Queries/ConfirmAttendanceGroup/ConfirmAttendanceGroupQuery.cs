﻿using MediatR;
using SharijhaAward.Domain.Entities.InvitationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.InviteeForm.Group.Queries.ConfirmAttendanceGroup
{
    public class ConfirmAttendanceGroupQuery : IRequest<Unit>
    {
        public Guid Id { get; set; }
        public int NumberOfAttendees {  get; set; }
        //public List<string>? StudentNames { get; set; }
    }
}
