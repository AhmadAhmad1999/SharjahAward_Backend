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
            if(response.StatusCode == 404)
                return NotFound(
                    new
                    {
                         response.Success,
                         response.Message,
                         response.StatusCode
                         
                    });

            return Ok(
                new
                {
                    response.Data,
                    response.Success,
                    response.Message,
                    response.StatusCode
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

            if(response.StatusCode==404)
                return NotFound(new { response.Message });
            else
                return Ok(new { response.Message });
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

            if (response.StatusCode == 404)
                return NotFound(
                    new 
                    { 
                        response.Message,
                        response.StatusCode
                    });
            else
                return Ok(
                    new 
                    { 
                        response.Message,
                        response.StatusCode
                    });
        }
        [HttpGet("{id}",Name="GetNewsById")]
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

            if (response.StatusCode == 404)
                return NotFound(
                    new 
                    { 
                        response.Message,
                        response.StatusCode
                    });
            else
                return Ok(
                    new 
                    { 
                        response.Message,
                        response.StatusCode,
                        response.Data

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
                lang = headerValue,
                page = page,
                pageSize = pageSize
            });
            int totalCount = dto.DataList.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            
            if(dto.StatusCode == 404)
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

        [HttpGet(Name = "GetNewsByCycleId")]
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
                lang = headerValue,
                page = page,
                pageSize = pageSize,
                CycleId = CycleId
                
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
