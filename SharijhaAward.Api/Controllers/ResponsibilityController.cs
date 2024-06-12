using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Circulars.Command.CreateCircular;
using SharijhaAward.Application.Features.Circulars.Command.DeleteCircular;
using SharijhaAward.Application.Features.Circulars.Command.UpdateCircular;
using SharijhaAward.Application.Features.Circulars.Queries.GetAllCirculars;
using SharijhaAward.Application.Features.Circulars.Queries.GetCircularById;
using SharijhaAward.Application.Features.Responsibilities.Commands.CreateResponsibility;
using SharijhaAward.Application.Features.Responsibilities.Commands.DeleteResponsibility;
using SharijhaAward.Application.Features.Responsibilities.Commands.UpdateResponsibility;
using SharijhaAward.Application.Features.Responsibilities.Queries.AcceptOnResponsibility;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetResponsibilityById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsibilityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ResponsibilityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateResponsibility")]
        public async Task<IActionResult> CreateResponsibility(CreateResponsibilityCommand command)
        {
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

        [HttpDelete("{Id}", Name = "DeleteResponsibility")]
        public async Task<IActionResult> DeleteResponsibility(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteResponsibilityCommand()
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

        [HttpPut(Name = "UpdateResponsibility")]
        public async Task<IActionResult> UpdateResponsibility(UpdateResponsibilityCommand command)
        {
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

        [HttpGet(Name = "GetAllResponsibilities")]
        public async Task<IActionResult> GetAllResponsibilities(int? RoleId, int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllResponsibilitiesQuery()
            {
                page = page,
                perPage = perPage,
                RoleId = RoleId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{Id}", Name = "GetResponsibilityById")]
        public async Task<IActionResult> GetResponsibilityById(int Id)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetResponsibilityByIdQuery()
            {
                lang = language!,
                Id = Id
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetAllResponsibilitiesByUserId", Name = "GetAllResponsibilitiesByUserId")]
        public async Task<IActionResult> GetAllResponsibilitiesByUserId(int UserId)
        {
            var language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new GetAllResponsibilitiesByUserIdQuery()
            {
                lang = language!,
                UserId = UserId,
                UserToken = token
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPut("AcceptOnResponsibility", Name = "AcceptOnResponsibility")]
        public async Task<IActionResult> AcceptOnResponsibility(int ResponsibilityId, bool Accept)
        {
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _mediator.Send(new AcceptOnResponsibilityQuery()
            {
                Accept = Accept,
                ResponsibilityId = ResponsibilityId,
                token = token!
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
