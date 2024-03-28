using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SelectPdf;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.CreateExplanatoryGuide;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.DeleteExplanatoryGuide;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.UpdateExplanatoryGuide;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideDetailsByCategoryId;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplanatoryGuideController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public ExplanatoryGuideController(IMediator mediator, IWebHostEnvironment webHostEnvironment)
        {
            _mediator = mediator;
            _WebHostEnvironment = webHostEnvironment;
        }

        [HttpPost(Name = "CreateExplanatoryGuide")]
        public async Task<IActionResult> CreateExplanatoryGuide([FromForm] CreateExplanatoryGuideCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            command.lang = Language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}" ,Name = "GetExplanatoryGuideByCategoryId")]
        public async Task<IActionResult> GetExplanatoryGuideByCategoryId(Guid Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var response = await _mediator.Send(new GetExplanatoryGuideByCategoryIdQuery() 
            {
                CategoryId = Id,
                lang = Language!
            });
            return response.statusCode switch
            {
                // Return the file as a downloadable response
                200 => File(response.data!.fileContent, "application/pdf", "ExplanatoryGuide.pdf"),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
          
        }

        [HttpGet("GetExplanatoryGuideDetailsByCategoryId/{Id}", Name = "GetExplanatoryGuideDetailsByCategoryId")]
        public async Task<IActionResult> GetExplanatoryGuideDetailsByCategoryId(Guid Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var response = await _mediator.Send(new GetExplanatoryGuideDetailsByCategoryIdQuery()
            {
                CategoryId = Id,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete(Name= "DeleteExplanatoryGuide")]
        public async Task<IActionResult> DeleteExplanatoryGuide(Guid Id)
        {
            var Language = HttpContext.Request.Headers["lang"];
            var response = await _mediator.Send(new DeleteExplanatoryGuideCommand()
            {
                GuideId = Id,
                lang = Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut(Name = "UpdateExplanatoryGuide")]
        public async Task<IActionResult> UpdateExplanatoryGuide([FromForm] UpdateExplanatoryGuideCommand command)
        {
            var Language = HttpContext.Request.Headers["lang"];
            command.lang = Language!;
            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

    }
}
