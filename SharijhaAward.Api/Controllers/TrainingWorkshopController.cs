using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.DeleteWorkshopAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.ExportToExcel;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.AppVersioningFeatures.Command.CreateNewAppVersion;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingWorkshopController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _environment;
        private readonly IFileService _fileService;

        public TrainingWorkshopController(IFileService fileService, IMediator mediator, IWebHostEnvironment environment)
        {
            _Mediator = mediator;
            _environment = environment;
            _fileService = fileService;
        }

        [HttpPost(Name = "CreateTrainingWorkshop")]

        public async Task<ActionResult> CreateTrainingWorkshop([FromForm] CreateTrainingWorkshopsCommand CreateTrainingWorkshopsCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            CreateTrainingWorkshopsCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            BaseResponse<int>? Response = await _Mediator.Send(CreateTrainingWorkshopsCommand);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut(Name = "UpdateTringingWorkshop")]

        public async Task<ActionResult> UpdateTringingWorkshop([FromForm] UpdateTrainingWorkshopCommand command)
        {
            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete(Name = "DeleteTrainingWorkshop")]
        public async Task<ActionResult> DeleteTrainingWorkshop(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new DeleteTrainingWorkshopCommand() {Id = Id });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpGet("{Id}", Name = "GetTrainingWorkshopById")]

        public async Task<ActionResult> GetTrainingWorkshopById(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new GetTrainingWorkshopByIdQuery()
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
        [HttpGet(Name="GetAllTrainingWorkshops")]
        public async Task<ActionResult> GetAllTrainingWorkshops(int page = 1, int perPage = 10)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];

            //get data from mediator
            var response = await _Mediator.Send(new GetAllTrainingWorkshopsQuery()
            {
                lang = Language!,
                perPage=perPage,
                page = page,
                
                
            });
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpGet("GetWorkShopsByCategoryId",Name= "GetWorkShopsByCategoryId")]
        public async Task<IActionResult> GetTrainingWorkShopsByCategoryId([FromQuery] GetWorkShopsByCategoryIdQuery query)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            query.lang = language!;

            var response = await _Mediator.Send(query);
            
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }
        [HttpPost("AddAttachmentToTrainingWorkShop", Name ="AddAttachmentToTrainingWorkShop")]
        public async Task<IActionResult> AddAttachmentToTrainingWorkShop([FromForm] CreateWorkshopeAttachmentCommand command)
        {
            var response = await _Mediator.Send(command);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
        [HttpPut("UpdateAttachmentOfTrainingWorkShop",Name= "UpdateAttachmentOfTrainingWorkShop")]
        public async Task<IActionResult> UpdateAttachmentOfTrainingWorkShop(UpdateWorkshopAttachmentCommand command)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];
           
            command.lang = language!;

            var response = await _Mediator.Send(command);
            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpDelete("DeleteAttachmentOfTrainingWorkShop/{Id}", Name = "DeleteAttachmentOfTrainingWorkShop")]
        public async Task<IActionResult> DeleteAttachmentOfTrainingWorkShop(int Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new DeleteWorkshopAttachmentCommand()
            {
                Id = Id ,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("TrainingWorkshopsExportToExcel", Name = "TrainingWorkshopsExportToExcel")]
        public async Task<IActionResult> TrainingWorkshopsExportToExcel()
        {
            var response = await _Mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TrainingWorkshops.xlsx"),
                _ => BadRequest(response)
            };
        }

    }
}
