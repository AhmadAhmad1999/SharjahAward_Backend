using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Cycles.Commands.CreateCycle;
using SharijhaAward.Application.Features.Cycles.Commands.DeleteCycle;
using SharijhaAward.Application.Features.Cycles.Commands.UpdateCycle;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.Cycles.Queries.GetCycleById;
using SharijhaAward.Application.Features.Cycles.Queries.GetLimteNumberOfCategories;
using SharijhaAward.Application.Features.GeneralFAQs.Commands.DeleteGeneralFAQ;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Api.Logger;

namespace SharijhaAward.Api.Controllers
{
    // [ServiceFilter(typeof(LogFilterAttribute))]
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
        public async Task<IActionResult> CreateCycle([FromBody] CreateCycleCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang = Language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut(Name = "UpdateCycle")]
        public async Task<IActionResult> UpdateCycle(UpdateCycleCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang = Language!;

            var response = await _mediator.Send(command);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetCycleById")]
        public async Task<IActionResult> GetCycleById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(
                new GetCycleByIdQuery
                {
                    Id = Id,
                    lang = Language!
                });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name = "GetAllCycle")]
        public async Task<IActionResult> GetAllCycle(int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            //get data from mediator
            var response = await _mediator.Send(new GetAllCyclesQuery()
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
        [HttpGet("GetLimitedNumberOfCategories", Name = "GetLimitedNumberOfCategories")]
        public async Task<IActionResult> GetLimitedNumberOfCategories()
        {
            //get data from mediator
            var response = await _mediator.Send(new GetLimteNumberOfCategoriesQuery());

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("{id}" ,Name="DeleteCycle")]
        public async Task<IActionResult> DeleteCycle(int id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object>? Response = await _mediator.Send(new DeleteCycleCommand()
            {
                Id = id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
