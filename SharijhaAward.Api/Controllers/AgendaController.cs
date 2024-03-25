using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgendaController : ControllerBase
    {
        private readonly IMediator _mediator;
      
        public AgendaController(IMediator mediator)
        {
            _mediator = mediator;
           
        }

        [HttpPost(Name = "AddAgenda")]
        public async Task<IActionResult> AddAgenda([FromForm] CreateAgendaCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
          
        }

        [HttpPut(Name="UpdateAgenda")]
        public async Task<IActionResult> UpdateAgenda([FromForm] UpdateAgendaCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            command.lang = language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
           
        }

        [HttpDelete(Name="DeleteAgenda")]
        public async Task<IActionResult> DeleteAgenda(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteAgendaCommand()
            {
                Id = Id,
                lang = language!
            });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
           
        }

        [HttpGet(Name = "GetAllAgenda")]
        public async Task<IActionResult> GetAllAgenda(int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllAgendaQuery
            {
                lang = Language!,
                page = page,
                pageSize = perPage 
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("{Id}", Name="GetAgendaById")]
        public async Task<IActionResult> GetAgendaById(Guid Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAgendaByIdQuery()
            {
                Id = Id,
                lang = Language!
            }) ;

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("GetAgendasByCycleId/{Id}",Name ="GetAgendasByCycleId")]
        public async Task<IActionResult> GetAgendasByCycleId(Guid? Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAgendaByCycleIdQuery()
            {
                CycleId = Id,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
