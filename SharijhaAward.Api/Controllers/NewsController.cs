using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.News.Commands.CreateNews;
using SharijhaAward.Application.Features.News.Commands.DeleteNews;
using SharijhaAward.Application.Features.News.Commands.UpdateNews;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.News.Queries.ExportToExcel;
using SharijhaAward.Application.Features.News.Commands.DeleteNewsImage;
using SharijhaAward.Application.Features.News.Queries.HideNews;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public NewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name ="AddNews")]
        public async Task<IActionResult> AddNews([FromForm] CreateNewsCommand command)
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
        [HttpDelete("{Id}", Name="DeleteNews")]
        public async Task<IActionResult> DeleteNews(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteNewsCommand()
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

        [HttpDelete("DeleteNewsImage/{Id}", Name = "DeleteNewsImage")]
        public async Task<IActionResult> DeleteNewsImage(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteNewsImageCommand()
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

        [HttpPut(Name = "UpdateNews")]
        public async Task<IActionResult> UpdateNews([FromForm] UpdateNewsCommand command)
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
        [HttpGet("{Id}",Name="GetNewsById")]
        public async Task<IActionResult> GetNewsById(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetNewsByIdQuery()
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
        
        [HttpGet(Name ="GetAllNews")]
        public async Task<IActionResult> GetAllNews([FromQuery] GetAllNewsQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetNewsForWebsite", Name = "GetNewsForWebsite")]
        public async Task<IActionResult> GetNewsForWebsite(string? query, int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            //get data from mediator
            var response = await _mediator.Send(new GetNewsForWebsiteQuery()
            {
                lang = Language!,
                page = page,
                perPage = perPage,
                query = query
            });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        
        [HttpPut("HideNews", Name = "HideNews")]
        public async Task<IActionResult> HideNews(HideNewsQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(query);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("NewsExportToExcel", Name = "NewsExportToExcel")]
        public async Task<IActionResult> NewsExportToExcel()
        {
            var response = await _mediator.Send(new NewsExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "News.xlsx"),
                _ => BadRequest(response)
            };
        }
    }
}
