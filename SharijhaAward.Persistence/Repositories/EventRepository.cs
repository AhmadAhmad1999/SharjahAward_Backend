using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Persistence.Repositories
{
    public class EventRepository : BaseRepository<Domain.Entities.EventModel.Event>, IEventRepository
    {
        public EventRepository(SharijhaAwardDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Event> GetEventWithInvitees(int ID)
        {
            var Event = await _dbContext.Events
                .FirstOrDefaultAsync(x => x.Id == ID);

            if(Event == null)
                throw new OpenQA.Selenium.NotFoundException();

            return Event;
        }
    }
}
