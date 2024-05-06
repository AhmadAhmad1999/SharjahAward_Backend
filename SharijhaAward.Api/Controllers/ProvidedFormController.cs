using Aspose.Pdf;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm;
using SharijhaAward.Application.Features.ProvidedForm.Command.DeleteProvidedForm;
using SharijhaAward.Application.Features.ProvidedForm.Queries.ChangeStep;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsBySubscriberId;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById;
using SharijhaAward.Application.Features.ProvidedForm.Queries.SigningTheForm;
using SharijhaAward.Domain.Constants.ProvidedFromConstants;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidedFormController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProvidedFormController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateProvidedForm")]
        public async Task<IActionResult> CreateProvidedForm(CreateProvidedFormCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            command.token = token!;
            command.lang = Language!;

            var response = await _mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete(Name="DeleteProvidedForm")]
        public async Task<IActionResult> DeleteProvidedForm(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new DeleteProvidedFormCommand()
            {
                lang =Language!,
                providedFormId = Id
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPost("ChangeStep", Name= "ChangeStep")]
        public async Task<IActionResult> ChangeStep(ChangeStepQuery query)
        {
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet(Name="GetAllProvidedForm")]
        public async Task<IActionResult> GetAllProvidedForm([FromQuery] ProvidedFormType? Type)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            var response = await _mediator.Send(new GetAllProvidedFormsQuery()
            {
                token = token!,
                Type = Type,
                lang= Language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("{UserId}/{Id}", Name="GetProvidedFormById")]
        public async Task<IActionResult> GetProvidedFormById(int? UserId,int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetProvidedFormByIdQuery()
            {
                UserId = UserId,
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
        [HttpPost("SigningTheForm", Name= "SigningTheForm")]
        public async Task<IActionResult> SigningTheForm(SigningTheFormQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetProvidedFormsBySubscriberId/{Id}", Name = "GetProvidedFormsBySubscriberId")]
        public async Task<IActionResult> GetProvidedFormsBySubscriberId(int Id , int page = 1, int pageSize = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            var response = await _mediator.Send(new GetFormsBySubscriberIdQuery()
            {
                lang = Language!,
                page= page,
                pageSize = pageSize,
                Id = Id
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
    }
}
