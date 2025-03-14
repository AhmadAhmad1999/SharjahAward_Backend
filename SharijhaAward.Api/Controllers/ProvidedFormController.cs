﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm;
using SharijhaAward.Application.Features.ProvidedForm.Command.DeleteProvidedForm;
using SharijhaAward.Application.Features.ProvidedForm.Queries.ChangeStep;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsBySubscriberId;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById;
using SharijhaAward.Application.Features.ProvidedForm.Queries.SigningTheForm;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToCoordinator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToArbitrator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToArbitrator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.UnAsignFormToCoordinator;
using SharijhaAward.Application.Features.ProvidedForm.Queries.AcceptOnForm;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllCriterionsForCoordinator;
using SharijhaAward.Application.Responses;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsWithArbitrators;
using SharijhaAward.Application.Features.ProvidedForm.Queries.ExportFormsWithArbitratorsToExcel;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFormsWithAllItsData;
using SharijhaAward.Application.Features.ProvidedForm.Queries.ExportFormsWithAllItsDataToExcel;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllFilesByFormId;
using Microsoft.AspNetCore.Hosting;
using SharijhaAward.Application.Features.ProvidedForm.Command.OpenFormForUpdate;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidedFormController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public ProvidedFormController(IMediator mediator,
            IWebHostEnvironment _WebHostEnvironment)
        {
            _Mediator = mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
        }

        [HttpPost(Name = "CreateProvidedForm")]
        public async Task<IActionResult> CreateProvidedForm(CreateProvidedFormCommand command)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            command.token = token!;
            command.lang = Language!;

            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                _ => BadRequest(response)
            };
        }
        [HttpDelete("{Id}",Name="DeleteProvidedForm")]
        public async Task<IActionResult> DeleteProvidedForm(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new DeleteProvidedFormCommand()
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
            var response = await _Mediator.Send(query);

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

            query.lang = Language!;
            query.token = token!;

            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetAllFormsForAllSubscriber", Name = "GetAllFormsForAllSubscriber")]
        public async Task<IActionResult> GetAllFormsForAllSubscriber([FromQuery] GetAllFormsForAllSubscriberQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            query.lang = Language!;
            query.Token = token!;
            //if (token.IsNullOrEmpty())
            //{
            //    return Unauthorized();
            //}
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetFormsWithArbitrators", Name = "GetFormsWithArbitrators")]
        public async Task<IActionResult> GetFormsWithArbitrators([FromQuery] GetFormsWithArbitratorsQuery query)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            //query.lang = Language!;
            //query.Token = token!;
            //if (token.IsNullOrEmpty())
            //{
            //    return Unauthorized();
            //}
            var response = await _Mediator.Send(query);

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

            var response = await _Mediator.Send(new GetProvidedFormByIdQuery()
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
            var language = HttpContext.Request.Headers["lang"];

            query.token = token!;
            query.lang = string.IsNullOrEmpty(language) ? "ar" : language!;

            query.WWWRootFilePath = _WebHostEnvironment.WebRootPath;

            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetProvidedFormsBySubscriberId/{Id}", Name = "GetProvidedFormsBySubscriberId")]
        public async Task<IActionResult> GetProvidedFormsBySubscriberId(int Id , int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var token = HttpContext.Request.Headers.Authorization;

            var response = await _Mediator.Send(new GetFormsBySubscriberIdQuery()
            {
                lang = Language!,
                page= page,
                perPage = perPage,
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

            query.token = token!;
            query.lang = Language!;

            var response = await _Mediator.Send(query);

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

            query.token = token!;
            query.lang = Language!;

            var response = await _Mediator.Send(query);

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

            query.token = token!;
            query.lang = Language!;

            var response = await _Mediator.Send(query);

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

            query.token = token!;
            query.lang = Language!;

            var response = await _Mediator.Send(query);

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

            query.token = token!;
            query.lang = Language!;

            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                200 => Ok(response),
                401 => Unauthorized(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("GetAllCriterionsForCoordinator")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCriterionsForCoordinator(int FormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllCriterionsForCoordinatorListVM>> Response = await _Mediator.Send(new GetAllCriterionsForCoordinatorQuery()
            {
                lang = HeaderValue!,
                FormId = FormId
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ExportFormsWithArbitratorsToExcel", Name = "ExportFormsWithArbitratorsToExcel")]
        public async Task<IActionResult> ExportFormsWithArbitratorsToExcel([FromQuery] ExportFormsWithArbitratorsToExcelQuery query)
        {
            var response = await _Mediator.Send(query);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ProvidedFormsWithArbitrators.xlsx"),
                _ => BadRequest(response)
            };
        }
        [HttpGet("GetAllFormsWithAllItsData")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFormsWithAllItsData([FromQuery] GetAllFormsWithAllItsDataQuery GetAllFormsWithAllItsDataQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllFormsWithAllItsDataQuery.lang = HeaderValue!;

            BaseResponse<List<GetAllFormsWithAllItsDataListVM>> Response = await _Mediator.Send(GetAllFormsWithAllItsDataQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("ExportFormsWithAllItsDataToExcel")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ExportFormsWithAllItsDataToExcel([FromQuery] ExportFormsWithAllItsDataToExcelQuery ExportFormsWithAllItsDataToExcelQuery)
        {
            BaseResponse<byte[]> Response = await _Mediator.Send(ExportFormsWithAllItsDataToExcelQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => File(Response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Forms.xlsx"),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllFilesByFormId/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllFilesByFormId(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllFilesByFormIdMainResponse>> Response = await _Mediator.Send(new GetAllFilesByFormIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("OpenFormForUpdate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> OpenFormForUpdate(int ProvidedFormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<object> Response = await _Mediator.Send(new OpenFormForUpdateCommand()
            {
                ProvidedFormId = ProvidedFormId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
    }
}
