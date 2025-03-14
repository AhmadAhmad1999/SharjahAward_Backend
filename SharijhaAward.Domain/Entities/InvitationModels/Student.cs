﻿using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.InvitationModels
{
    public class Student : AuditableEntity
    {
        public int Id { get; set; }
        public string StudentName { get; set; } = string.Empty;
        public GroupInvitee GroupInvitee { get; set; } = null!;

        [ForeignKey(nameof(GroupInvitee))]
        public int GroupInviteeId {  get; set; }
    }
}
