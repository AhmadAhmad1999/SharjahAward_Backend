using Aspose.Pdf.Plugins;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Categories.Command.CreateCategory;
using SharijhaAward.Application.Features.Categories.Command.UpdateCategory;
using SharijhaAward.Application.Features.Categories.Queries;
using SharijhaAward.Application.Features.Categories.Queries.GatCategoryById;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;

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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreteCategory([FromBody] CreateCategoryCommand command)
        {
          var response = await _mediator.Send(command);
            return StatusCode(201,
            new
            { 
               message = response
            });
        }
        [HttpPut(Name = "UpdateCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateCategory([FromBody] UpdateCategoryCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(
                new
                {
                    message = response
                });
        }
        [HttpGet(Name="GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllCategories(int page , int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            //get data from mediator
            var dto = await _mediator.Send(new GetAllCategoryQuery() { lang = headerValue });

            // Pagenation
            if (perPage == 0)
                perPage = 10;
            else if (perPage == -1)
                return Ok(
                new
                {
                    data = dto,
                    status = true,
                });

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
        [HttpGet("{Id}",Name ="GetCategoryById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetCategoryById(Guid Id)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            var category = await _mediator.Send(new GetCategoryByIdQuery()
            {
                Id = Id,
                lang = headerValue
            });

            return Ok(
                new 
                {
                    data = category,
                });
        }

    }
}
