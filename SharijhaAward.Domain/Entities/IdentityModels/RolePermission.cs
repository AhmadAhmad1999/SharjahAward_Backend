﻿using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.IdentityModels
{
    public class RolePermission : AuditableEntity
    {
        public int Id { get; set; }
        public int PermissionId { get; set; }
        public Permission? Permission { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
