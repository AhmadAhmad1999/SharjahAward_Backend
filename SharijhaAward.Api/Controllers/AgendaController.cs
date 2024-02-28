using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Agendas.Commands.CreateAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda;
using SharijhaAward.Application.Features.Agendas.Commands.UpdateAgenda;
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
        public async Task<ActionResult> AddAgenda(CreateAgendaCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;

            var response = await _mediator.Send(command);
            if (response.statusCode == 404)
            {
                return NotFound(new
                {
                    response.message,
                    response.statusCode,
                    response.success
                });
            }
            else if (response.statusCode == 200)
            {
                return Ok(new
                {
                    response.data,
                    response.message,
                    response.statusCode,
                    response.success
                });
            }
            else return BadRequest(new
            {
                response.message,
                response.statusCode,
            });
        }

        [HttpPut(Name="UpdateAgenda")]
        public async Task<ActionResult> UpdateAgenda([FromBody] UpdateAgendaCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;
            var response = await _mediator.Send(command);

            if (response.statusCode == 404)
                return NotFound(new { response.message, response.statusCode });
            else if (response.statusCode == 200)
                return Ok(new { response.message, response.statusCode });
            else return BadRequest(new { response });
        }

        [HttpDelete(Name="DeleteAgenda")]
        public async Task<ActionResult> DeleteAgenda(Guid Id)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new DeleteAgendaCommand()
            {
                Id = Id,
                lang = headerValue!
            });
            if(response.statusCode==404)
                return NotFound(new {response.message, response.statusCode});
            else if(response.statusCode==200)
                return Ok(new { response.message,response.statusCode});
            else return BadRequest(new { response });
        }

        [HttpGet(Name = "GetAllAgenda")]
        public async Task<ActionResult> GetAllAgenda(int page, int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            if (perPage == 0)
                perPage = 10;

            var response = await _mediator.Send(new GetAllAgendaQuery
            {
                lang = headerValue!,
                page = page,
                pageSize = perPage
            });

            if (response.statusCode == 404)
                return NotFound(new { response.message, response.statusCode, });
            else if (response.statusCode == 200)
            {
                var totalCount = response.data!.Count;
                var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

                return Ok(new 
                { 
                    response.data, 
                    response.statusCode,
                    response.success,
                    pagination =
                        new
                        {
                            current_page = page,
                            last_page = page - 1,
                            total_row = totalCount,
                            per_page = perPage,
                            totalPage
                        }
                });
            }
            else
                return BadRequest(new { response });

        }
        [HttpGet("{Id}", Name="GetAgendaById")]
        public async Task<ActionResult> GetAgendaById(Guid Id)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new GetAgendaByIdQuery()
            {
                Id = Id,
                lang = headerValue!
            }) ;


            if (response.statusCode == 404)
                return NotFound(new { response.message, response.statusCode, });
            else if (response.statusCode == 200)
                return Ok(new
                {
                    response.data,
                    response.statusCode,
                    response.success,
                   
               });
            
            else
                return BadRequest(new { response });


        }
    }
}
