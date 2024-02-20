using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
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
        [HttpPost]
        public async Task<ActionResult> CreateCycle([FromBody] CreateCycleCommand command)
        {
            var rsponse = await _mediator.Send(command);
            return StatusCode(201, new { data = rsponse } );
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
                lang = headerValue,
                page = page,
                pageSize = pageSize
            });
            int totalCount = dto.DataList.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);

            if (dto.StatusCode == 404)
            {
                return NotFound(new
                {
                    dto.Message,
                    dto.StatusCode
                });
            }
            return Ok(
               new
               {
                   data = dto.DataList,
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
