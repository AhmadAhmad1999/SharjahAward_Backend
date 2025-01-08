using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Features.FAQs.Queries.GetFAQById;
using SharijhaAward.Application.Features.FAQs.Queries.GetFAQsByCategoryId;
using SharijhaAward.Application.Features.FAQs.Queries.SearchForFAQs;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.FAQs.Queries.ExportToExcel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FAQController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateFAQ")]
        public async Task<IActionResult> CreateFAQ(CreateFAQCommand command)
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

        [HttpPut(Name = "UpdateFAQ")]
        public async Task<IActionResult> UpdateFAQ([FromBody] UpdateFAQCommand command)
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

        [HttpDelete(Name = "DeleteFAQ")]
        public async Task<IActionResult> DeleteFAQ(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteFAQCommand()
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

        [HttpGet("{Id}",Name="GetFAQById")]
        public async Task<IActionResult> GetFAQById(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetFAQByIdQuery()
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

        [HttpGet(Name ="GetAllFAQs")]
        public async Task<IActionResult> GetAllFAQs(int perPage = 10, int page = 1)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            //get data from mediator
            var response = await _mediator.Send(new GetAllFAQsQuery() 
            {
                lang = language!,
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


        [HttpGet("GetAllFAQsByCategoryId", Name = "GetAllFAQsByCategoryId")]
        public async Task<IActionResult> GetAllFAQsByCategoryId([FromQuery] GetAllFAQsByCategoryIdQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            //get data from mediator
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("SearchForFAQs", Name = "SearchForFAQs")]
        public async Task<IActionResult> SearchForFAQs(string? SearchQuery)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            //get data from mediator
            var response = await _mediator.Send(new SearchForFAQsQuery()
            {
                lang = language!,
                SrearchQuery = SearchQuery
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("FAQExportToExcel", Name = "FAQExportToExcel")]
        public async Task<IActionResult> FAQExportToExcel()
        {
            var response = await _mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "FAQs.xlsx"),
                _ => BadRequest(response)
            };
        }

    }
}
