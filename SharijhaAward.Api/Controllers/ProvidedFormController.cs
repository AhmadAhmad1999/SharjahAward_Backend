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
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToCoordinator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToArbitrator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToArbitrator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToCoordinator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AcceptOnForm;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
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
        public async Task<IActionResult> GetAllProvidedForm([FromQuery] GetAllProvidedFormsQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }

            query.lang = Language!;
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

        [HttpGet("GetAllFormsForAllSubscriber", Name = "GetAllFormsForAllSubscriber")]
        public async Task<IActionResult> GetAllFormsForAllSubscriber(int page = 1, int pageSize = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            //if (token.IsNullOrEmpty())
            //{
            //    return Unauthorized();
            //}
            var response = await _mediator.Send(new GetAllFormsForAllSubscriberQuery()
            {
                page=page,
                pageSize = pageSize,
                lang = Language!
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

        [HttpPost("AsignFormToCoordinator", Name = "AsignFormToCoordinator")]
        public async Task<IActionResult> AsignFormToCoordinator(AsignFormToCoordinatorQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("UnAsignFormToCoordinator", Name = "UnAsignFormToCoordinator")]
        public async Task<IActionResult> UnAsignFormToCoordinator([FromQuery] UnAsignFormToCoordinatorQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpPost("AsignFormToArbitrator", Name = "AsignFormToArbitrator")]
        public async Task<IActionResult> AsignFormToArbitrator(AsignFormToArbitratorQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("UnAsignFormToArbitrator", Name = "UnAsignFormToArbitrator")]
        public async Task<IActionResult> UnAsignFormToArbitrator([FromQuery] UnAsignFormToArbitratorQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            query.lang = Language!;

            var response = await _mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPut("AcceptOnForm", Name = "AcceptOnForm")]
        public async Task<IActionResult> AcceptOnForm(AcceptOnFormQuery query)
        {
            var token = HttpContext.Request.Headers.Authorization;

            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            if (token.IsNullOrEmpty())
            {
                return Unauthorized();
            }
            query.token = token!;
            query.lang = Language!;

            var response = await _mediator.Send(query);

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
