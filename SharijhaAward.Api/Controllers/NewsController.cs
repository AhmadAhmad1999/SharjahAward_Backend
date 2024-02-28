using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.News.Commands.CreateNews;
using SharijhaAward.Application.Features.News.Commands.DeleteNews;
using SharijhaAward.Application.Features.News.Commands.UpdateNews;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;

namespace SharijhaAward.Api.Controllers
{
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
        public async Task<IActionResult> AddNews(CreateNewsCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;

            var response = await _mediator.Send(command);
            if(response.statusCode == 404)
                return NotFound(
                    new
                    {
                         response.success,
                         response.message,
                         response.statusCode
                         
                    });

            return Ok(
                new
                {
                    response.data,
                    response.success,
                    response.message,
                    response.statusCode
                });
        }
        [HttpDelete(Name="DeleteNews")]
        public async Task<IActionResult> DeleteNews(Guid Id)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new DeleteNewsCommand()
            {
                Id = Id,
                lang = headerValue!
            });

            if(response.statusCode==404)
                return NotFound(new { response.message });
            else
                return Ok(new { response.message });
        }
        [HttpPut(Name = "UpdateNews")]
        public async Task<IActionResult> UpdateNews(UpdateNewsCommand command)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            command.lang = headerValue!;
            var response = await _mediator.Send(command);

            if (response.statusCode == 404)
                return NotFound(
                    new 
                    { 
                        response.message,
                        response.statusCode
                    });
            else
                return Ok(
                    new 
                    { 
                        response.message,
                        response.statusCode
                    });
        }
        [HttpGet("{Id}",Name="GetNewsById")]
        public async Task<IActionResult> GetNewsById(Guid Id)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new GetNewsByIdQuery()
            {
                Id = Id,
                lang = headerValue!
            });

            if (response.statusCode == 404)
                return NotFound(
                    new 
                    { 
                        response.message,
                        response.statusCode
                    });
            else
                return Ok(
                    new 
                    { 
                        response.statusCode,
                        response.data

                    });
        }
        [HttpGet(Name ="GetAllNews")]
        public async Task<IActionResult> GetAllNews(int page , int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            int pageSize = perPage == 0 ? 10 : perPage;
            //get data from mediator
            var dto = await _mediator.Send(new GetAllNewsQuery()
            {
                lang = headerValue!,
                page = page,
                pageSize = pageSize
            });
           
            int totalCount = dto.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            return Ok(
                new
                {
                    dto.data,
                    dto.statusCode,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = page - 1,
                        total_row = totalCount,
                        per_page = pageSize,
                        totalPage,
                        currentPageCount= dto.data!.Count
                    }

                });
        }

        [HttpGet("GetNewsByCycleId",Name = "GetNewsByCycleId")]
        public async Task<IActionResult> GetNewsByCycleId(int page, int perPage, Guid CycleId)
        {
            //get Language from header

            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            int pageSize = perPage == 0 ? 10 : perPage;

            //get data from mediator
            var dto = await _mediator.Send(new GetNewsByCycleIdQuery()
            {
                lang = headerValue!,
                page = page,
                pageSize = pageSize,
                CycleId = CycleId
                
            });
            int totalCount = dto.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);

            return Ok(
                new
                {
                    dto,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = pageSize,
                        currentPageCount= dto.data!.Count
                    }

                });
        }
    }
}
