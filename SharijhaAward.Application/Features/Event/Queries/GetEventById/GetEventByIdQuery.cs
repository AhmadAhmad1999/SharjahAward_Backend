using MediatR;

namespace SharijhaAward.Application.Features.Event.Queries.GetEventById
{
    public class GetEventByIdQuery : IRequest<EventDto>
    {
        public int Id { get; set; }
        public string? lang {  get; set; }
    }
}
