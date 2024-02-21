using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;
using SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.Cycles.Queries.GetCycleById;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CycleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CycleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost(Name = "CreateCycle")]
        public async Task<ActionResult> CreateCycle([FromBody] CreateCycleCommand command)
        {
            var rsponse = await _mediator.Send(command);
            return StatusCode(201, new { data = rsponse } );
        }
        [HttpPut(Name="UpdateCycle")]
        public async Task<ActionResult> UpdateCycle(UpdateCycleCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;

            var response =await _mediator.Send(command);
            if(response.StatusCode == 404)
            {
                return NotFound(
                    new
                    {
                        response.Message,
                        response.StatusCode
                    });
            }
            return Ok(
                new
                {
                    response.Message,
                    response.StatusCode
                });
        }

        [HttpGet("{id}",Name="GetCycleById")]
        public async Task<ActionResult> GetCycleById(Guid Id)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(
                new GetCycleByIdQuery
                {
                    Id = Id,
                    lang = headerValue!
                });
            if(response.StatusCode == 404)
            {
                return NotFound(
                    new
                    { 
                        response.Message,
                        response.StatusCode 
                    });
            }
            return Ok(
                new
                {
                    response.Message,
                    response.StatusCode
                });
        }

        [HttpGet(Name ="GetAllCycle")]
        public async Task<IActionResult> GetAllCycle(int page , int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            int pageSize = perPage == 0 ? 10 : perPage;
            //get data from mediator
            var dto = await _mediator.Send(new GetAllCyclesQuery()
            {
                lang = headerValue!,
                page = page,
                pageSize = pageSize
            });
            

            if (dto.StatusCode == 404)
            {
                return NotFound(new
                {
                    dto.Message,
                    dto.StatusCode
                });
            }
            int totalCount = dto.Data.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            return Ok(
               new
               {
                   data = dto.Data,
                   dto.Message,
                   dto.StatusCode,
                   pagination =
                   new
                   {
                       current_page = page,
                       last_page = totalPage,
                       total_row = totalCount,
                       per_page = pageSize
                   }

               });
        }
    }
}
