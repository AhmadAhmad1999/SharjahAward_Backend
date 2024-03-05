﻿using MediatR;
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
        [HttpDelete(Name="DeleteNews")]
        public async Task<IActionResult> DeleteNews(Guid Id)
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
        [HttpPut(Name = "UpdateNews")]
        public async Task<IActionResult> UpdateNews(UpdateNewsCommand command)
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
        public async Task<IActionResult> GetNewsById(Guid Id)
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
        public async Task<IActionResult> GetAllNews(int page = 1 , int perPage = 10)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllNewsQuery()
            {
                page = page,
                pageSize = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
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
