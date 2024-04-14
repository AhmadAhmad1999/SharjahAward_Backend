using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Categories.Command.CreateCategory;
using SharijhaAward.Application.Features.Categories.Command.UpdateCategory;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoriesWithSubcategories;
using SharijhaAward.Application.Features.Categories.Command.DeleteCategory;


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
        public async Task<IActionResult> CreteCategory([FromForm] CreateCategoryCommand command)
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
        public async Task<IActionResult> UpdateCategory([FromForm] UpdateCategoryCommand command)
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
        [HttpDelete(Name = "DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteCategoryCommand() 
            {
                CategoryId = Id,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name="GetAllCategories")]
        public async Task<IActionResult> GetAllCategories(int? CycleId, int page = 1 , int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllCategoryQuery
            {
                lang = Language!,
                page = page,
                pageSize = perPage,
                CycleId = CycleId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}",Name ="GetCategoryById")]
        public async Task<IActionResult> GetCategoryById(int Id)
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
        [HttpGet("CategoriesWithSubcategories",Name = "CategoriesWithSubcategories")]
        public async Task<IActionResult> CategoriesWithSubcategories(int? CycleId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetCategoriesWithSubcategoriesQuery()
            {
                lang = Language!,
                CycleId = CycleId
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
