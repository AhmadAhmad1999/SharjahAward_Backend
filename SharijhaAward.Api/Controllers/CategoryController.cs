using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.Categories.Command.CreateCategory;
using SharijhaAward.Application.Features.Categories.Command.UpdateCategory;
using SharijhaAward.Application.Features.Categories.Queries.GatCategoryById;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;


namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name ="CreateCategory")]
        public async Task<IActionResult> CreteCategory([FromBody] CreateCategoryCommand command)
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
        [HttpPut(Name = "UpdateCategory")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand command)
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
        [HttpGet(Name="GetAllCategories")]
        public async Task<IActionResult> GetAllCategories(int page = 1 , int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllCategoryQuery
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
        [HttpGet("{Id}",Name ="GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(Guid Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCategoryByIdQuery()
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

    }
}
