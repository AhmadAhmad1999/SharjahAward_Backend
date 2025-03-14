﻿using SharijhaAward.Domain.Entities.EventModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Contract.Persistence
{
    public interface IEventRepository : IAsyncRepository<Event>
    {
        public Task<Event> GetEventWithInvitees(int ID);

    }
}
