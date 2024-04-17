﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.RoleMessageTypeModel
{
    public class RoleMessageType : AuditableEntity
    {
        public int Id { get; set; }

        public MessageType MessageType { get; set; } = null!;
        [ForeignKey(nameof(Type))]
        public int MessageTypeId { get; set; }

        public Role Role { get; set; } = null!;
        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }

    }
}
