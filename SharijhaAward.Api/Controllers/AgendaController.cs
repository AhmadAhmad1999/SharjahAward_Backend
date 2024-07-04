using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda;
using SharijhaAward.Application.Features.Agendas.Queries.ExportToExcel;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendasForAwardTeam;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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
        public async Task<IActionResult> DeleteAgenda(int Id)
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
                perPage = perPage 
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("{Id}", Name="GetAgendaById")]
        public async Task<IActionResult> GetAgendaById(int Id)
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
        [HttpGet("GetAgendasByCycleId",Name ="GetAgendasByCycleId")]
        public async Task<IActionResult> GetAgendasByCycleId(int? Id ,int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAgendaByCycleIdQuery()
            {
                page = page,
                perPage = perPage,
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
        [HttpGet("GetAgendasForAwardTeam", Name = "GetAgendasForAwardTeam")]
        public async Task<IActionResult> GetAgendasForAwardTeam(int? CycleId ,int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            //get token from header
            var token = HttpContext.Request.Headers.Authorization;

            if(token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            var response = await _mediator.Send(new GetAgendasForAwardTeamQuery()
            {
                page = page,
                perPage = perPage,
                CycleId = CycleId,
                token = token!,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("AgendasExportToExcel", Name = "AgendasExportToExcel")]
        public async Task<IActionResult> AgendasExportToExcel()
        {
            var response = await _mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Agendas.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
