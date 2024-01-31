using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Features.Event.Commands.DeleteEvent;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees;


namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IMediator _Mediator;
        public EventController(IMediator Mediator)
        {
            _Mediator = Mediator;
        }
        [HttpPost("CreateEvent", Name = "AddEvent")]
        public async Task<ActionResult<CreateEventCommandResponse>> Create([FromBody] CreateEventCommand CreateEventCommand)
        {
            CreateEventCommandResponse? Response = await _Mediator.Send(CreateEventCommand);
            return Ok(Response);
        }


        [HttpPut("UpdateEvent", Name = "UpdateEvent")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateEventCommand updateEventCommand)
        {
            await _Mediator.Send(updateEventCommand);
            return Ok(Response);
        }

        [HttpGet("GetAllEvents", Name = "GetAllEvents")]
        public async Task<ActionResult> GetAllEvents(int page , int perPage)
        {
            if (perPage == 0)
                perPage = 10;

            var dto = await _Mediator.Send(new GetAllEventsQuery());
            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            return Ok(
                new
                {
                    data = dataPerPage,
                    message = "Retrieved successfully.",
                    status = true,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    }
                });
        }
        [HttpDelete("DeleteEvent", Name = "DeleteEvent")]
        public async Task<ActionResult> DeleteEvent(Guid id)
        {
            var dtos = await _Mediator.Send(new DeleteEventCommand() { Id = id });
            return Ok("Delete Success");
        }

        [HttpGet("GetEventById/{id}", Name = "GetEventById")]
        public async Task<ActionResult> GetEventById(Guid id)
        {
            string lang;
            var headerValue = HttpContext.Request.Headers["lang"];
            if (string.IsNullOrWhiteSpace(headerValue))
                lang = headerValue;
            else
                lang = "";
            var Event = await _Mediator.Send(new GetEventByIdQuery() 
            {
                Id = id
            });

            if (lang == "ar")
            {
                EventDto ArabicResponse = new EventDtoArabic()
                {
                    Id = Event.Id,
                    ArabicDescription = Event.ArabicDescription,
                    ArabicName = Event.ArabicName,
                    EndDate = Event.EndDate,
                    StartDate = Event.StartDate
                };
                return Ok(new { data = ArabicResponse });
            }
            else 
            {
                EventDtoEnglish EnglishResponse = new EventDtoEnglish()
                {
                    Id = Event.Id,
                    EnglishDescription = Event.EnglishDescription,
                    EnglishName = Event.EnglishName,
                    EndDate = Event.EndDate,
                    StartDate = Event.StartDate
                };
                return Ok(new { data = EnglishResponse });
            }
               
            
        }
        [HttpGet("GetEventWithInvitees", Name = "GetEventWithInvitees")]
        public async Task<ActionResult> GetEventWithInvitees(Guid id)
        {
            var response = await _Mediator.Send(new GetEventWithInviteesQuery() { Id = id });
            return Ok(new { data = response });
        }
    }

    
}
