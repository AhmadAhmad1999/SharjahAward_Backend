﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.Albums.Commands.CreateAlbum;
using SharijhaAward.Application.Features.Albums.Commands.DeleteAlbum;
using SharijhaAward.Application.Features.Albums.Commands.UpdateAlbum;
using SharijhaAward.Application.Features.Albums.Galleries.Commands.CreateGallery;
using SharijhaAward.Application.Features.Albums.Galleries.Commands.DeleteGallery;
using SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries;
using SharijhaAward.Application.Features.Albums.Queries.GetAlbumById;
using SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlbumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAlbum")]
        public async Task<IActionResult> CreateAlbum([FromForm] CreateAlbumCommand command)
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

        [HttpPut(Name = "UpdateAlbum")]
        public async Task<IActionResult> UpdateAlbum([FromForm] UpdateAlbumCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteAlbum")]
        public async Task<IActionResult> DeleteAlbum(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteAlbumCommand()
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

        [HttpGet(Name = "GetAllAlbums")]
        public async Task<IActionResult> GetAllAlbums([FromQuery] GetAllAlbumsQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        
        [HttpGet("{Id}", Name = "GetAlbumById")]
        public async Task<IActionResult> GetAlbumById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAlbumByIdQuery()
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

        [HttpPost("CreateGallery", Name = "CreateGallery")]
        public async Task<IActionResult> CreateGallery([FromForm] CreateGalleryCommand command)
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

        [HttpDelete("DeleteGallery/{Id}", Name = "DeleteGallery")]
        public async Task<IActionResult> DeleteGallery(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteGalleryCommand()
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

        [HttpGet("GetAllGalleries/{AlbumId}", Name = "GetAllGalleries")]
        public async Task<IActionResult> GetAllGalleries(int AlbumId, int page = 1, int perPage = 10)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllGalleriesQuery()
            {
                AlbumId = AlbumId,
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
        
    }
}
