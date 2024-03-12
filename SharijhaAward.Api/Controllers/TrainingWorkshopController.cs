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
using SharijhaAward.Application.Features.TrainingWorkshops.Command.CreateTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.DeleteTrainingWorkshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Command.UpdateTrainingWrokshop;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;
using System;
using System.Text.Json.Nodes;

namespace SharijhaAward.Api.Controllers
{
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreateTrainingWorkshop([FromBody] CreateTrainingWorkshopsCommand command)
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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> UpdateTringingWorkshop([FromBody] UpdateTrainingWorkshopCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(
                new
                {
                    data = response,
                    message = "تم تعديل الدورة التدريبية بنجاح"
                });
        }
        [HttpDelete(Name = "DeleteTrainingWorkshop")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> DeleteTrainingWorkshop(Guid Id)
        {
            var response = await _mediator.Send(new DeleteTrainingWorkshopCommand() {Id = Id });
            return Ok(
                new
                {
                    data = response,
                    message = "تم حذف الدورة التدريبية بنجاح"
                });
        }
        [HttpGet("{Id}", Name = "GetTrainingWorkshopById")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetTrainingWorkshopById(Guid Id)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var respons = await _mediator.Send(new GetTrainingWorkshopByIdQuery()
            { 
                Id = Id,
                lang = headerValue
            });
            return Ok(
                new
                {
                    data = respons,
                });
        }
        [HttpGet(Name="GetAllTrainingWorkshops")]
        public async Task<ActionResult> GetAllTrainingWorkshops(int page, int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            //get data from mediator
            var dto = await _mediator.Send(new GetAllTrainingWorkshopsQuery()
            {
                lang = headerValue!
            });

            // Pagenation
            if (perPage == 0)
                perPage = 10;
            else if (perPage == -1)
                return Ok(
                new
                {
                    data = dto,
                    status = true,
                });

            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);
            var dataPerPage = dto
                .Skip((page - 1) * perPage)
                .Take(perPage)
                .ToList();

            return Ok(
                new
                {
                    data = dataPerPage,
                    status = true,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = perPage
                    }
                });
        }
        [HttpGet("GetWorkShopsByCategoryId/{Id}",Name= "GetWorkShopsByCategoryId")]
        public async Task<IActionResult> GetTrainingWorkShopsByCategoryId(Guid Id)
        {
            //get Language from header
            var language = HttpContext.Request.Headers["lang"];

            var response = await _mediator.Send(new GetWorkShopsByCategoryIdQuery()
            {
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
        [HttpGet("Video",Name = "Video")]
        //public async Task<IActionResult> Video()
        //{
        //    var filename = "file_example.mp4";
        //    string path = Path.Combine(_environment.WebRootPath, "UploadedFiles/") + "9f9adbfa-e681-4436-b70e-20021bd04da8.mp4";
        //    var filestream = await _fileService.ReadFileAsync(path);
        //    return File(filestream, contentType: "video/mp4", fileDownloadName: filename, enableRangeProcessing: true);
        //}
        public IActionResult GetVideo()
        {
            var videoFileName = $"video.mp4";

            // Path to video file
            var videoPath = Path.Combine(_environment.WebRootPath, "UploadedFiles/") + "e519392e-bdaa-4aaa-9cbb-a423738c55cc.mp4";

            if (!System.IO.File.Exists(videoPath))
            {
                return NotFound();
            }

            var memory = new MemoryStream();
            using (var stream = new FileStream(videoPath, FileMode.Open))
            {
                stream.CopyTo(memory);
            }

            memory.Position = 0;

            return File(memory, GetContentType(videoFileName), videoFileName);
        }

        private static string GetContentType(string file)
        {
            var types = new Dictionary<string, string>
            {
                {".mp4", "video/mp4"}
            };

            var ext = Path.GetExtension(file);

            return types[ext.ToLower()];
        }

    }
}
