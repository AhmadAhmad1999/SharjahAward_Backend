using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaById;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.AwardPublications.Commands.CreateAwardPublication;
using SharijhaAward.Application.Features.AwardPublications.Commands.DeleteAwardPublication;
using SharijhaAward.Application.Features.AwardPublications.Queries.DownloadAwardPublication;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardPublicationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AwardPublicationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateAwardPublication")]
        public async Task<IActionResult> CreateAwardPublication(CreateAwardPublicationCommand command)
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

        [HttpDelete("{Id}", Name = "DeleteAwardPublication")]
        public async Task<IActionResult> DeleteAwardPublication(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteAwardPublicationCommand()
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

        [HttpGet("{Id}", Name= "GetAwardPublicationById")]
        public async Task<IActionResult> GetAwardPublicationById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAwardPublicationByIdQuery()
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

        [HttpGet(Name = "GetAllAwardPublications")]
        public async Task<IActionResult> GetAllAwardPublications(int CycleId, int page = 1, int pageSize =10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetAllAwardPublicationsQuery
            {
                lang = Language!,
                page = page,
                pageSize = pageSize,
                CycleId = CycleId
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("DownloadAwardPublication/{Id}", Name = "DownloadAwardPublication")]
        public async Task<IActionResult> DownloadAwardPublication(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var response = await _mediator.Send(new DownloadAwardPublicationQuery()
            {
                PublicationId = Id,
                lang = Language!
            });
            return response.statusCode switch
            {
                // Return the file as a downloadable response
                200 => File(response.data!.fileContent, "application/pdf", response.data.fileFileName),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
    }
}
