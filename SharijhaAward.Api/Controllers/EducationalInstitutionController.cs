using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalInstitutionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EducationalInstitutionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name= "CreateEducationalInstitution")]
        public async Task<IActionResult> CreateEducationalInstitution(CreateEducationalInstitutionCommand command)
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
        [HttpGet(Name= "GetAllEducationalInstitution")]
        public async Task<IActionResult> GetAllEducationalInstitution(Guid? EducationalEntityId)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
           
            var response = await _mediator.Send(new GetAllEducationalInstitutionsQuery()
            {
                lang = Language!,
                EducationalEntityId = EducationalEntityId
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
