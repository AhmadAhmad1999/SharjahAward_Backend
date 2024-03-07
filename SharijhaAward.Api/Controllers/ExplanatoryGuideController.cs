using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SelectPdf;
using SharijhaAward.Application.Features.ExplanatoryGuides.Commands.CreateExplanatoryGuide;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;
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

            // Return the file as a downloadable response
            return File(response.data!.fileContent, "application/pdf", "ExplanatoryGuide.pdf");
        }

    }
}
