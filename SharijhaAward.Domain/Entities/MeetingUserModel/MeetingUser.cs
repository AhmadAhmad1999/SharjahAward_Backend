﻿using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.MeetingModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Model.MeetingUserModel
{
    public class MeetingUser
    {
        public int Id { get; set; }

        public User User { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
    
        public Meeting Meeting { get; set; }

        [ForeignKey(nameof(Meeting))]
        public Guid MeetingId { get; set; }
    }
}
