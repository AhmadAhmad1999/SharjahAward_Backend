using Aspose.Pdf.Plugins;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using NPOI.HPSF;
using PdfSharpCore.Pdf;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.CreateWorkshpoeAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.DeleteWorkshopAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Attacments.Commands.UpdateWorkshopAttachment;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using System;
using System.Text.Json.Nodes;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.ExportToExcel;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingWorkshopController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IWebHostEnvironment _environment;
        private readonly IFileService _fileService;

        public TrainingWorkshopController(IFileService fileService, IMediator mediator, IWebHostEnvironment environment)
        {
            _mediator = mediator;
            _environment = environment;
            _fileService = fileService;
        }

        [HttpPost(Name = "CreateTrainingWorkshop")]

        public async Task<ActionResult> CreateTrainingWorkshop([FromForm] CreateTrainingWorkshopsCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(
                new
                {
                    data = response,
                    message = "تم إنشاء دورة تدريبية بنجاح"
                });
        }
        [HttpPut(Name = "UpdateTringingWorkshop")]

        public async Task<ActionResult> UpdateTringingWorkshop([FromForm] UpdateTrainingWorkshopCommand command)
        {
            var response = await _mediator.Send(command);

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

            var response = await _mediator.Send(new DeleteTrainingWorkshopCommand() {Id = Id });
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

            var response = await _mediator.Send(new GetTrainingWorkshopByIdQuery()
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
            var response = await _mediator.Send(new GetAllTrainingWorkshopsQuery()
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
        [HttpGet("GetWorkShopsByCategoryId/{Id}",Name= "GetWorkShopsByCategoryId")]
        public async Task<IActionResult> GetTrainingWorkShopsByCategoryId(int Id,int page = 1, int perPage = 10)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetWorkShopsByCategoryIdQuery()
            {
                page = page,
                perPage = perPage,
                CategoryId = Id,
                lang = language!
            });
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
            var response = await _mediator.Send(command);
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

            var response = await _mediator.Send(command);
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

            var response = await _mediator.Send(new DeleteWorkshopAttachmentCommand()
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
            var response = await _mediator.Send(new ExportToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TrainingWorkshops.xlsx"),
                _ => BadRequest(response)
            };
        }

    }
}
