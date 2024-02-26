using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Event.Commands.CreateEvent;
using SharijhaAward.Application.Features.Event.Commands.DeleteEvent;
using SharijhaAward.Application.Features.Event.Commands.UpdateEvent;
using SharijhaAward.Application.Features.Event.Queries.GetAllEvents;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Features.Event.Queries.GetEventWithInvitees;
using Aspose.Html;
using Aspose.Html.Converters;
using System.Net;
using BarcodeStandard;
using Microsoft.AspNetCore.Components.Web;
using Aspose.Pdf;
using System;
using PdfSaveOptions = Aspose.Pdf.PdfSaveOptions;
using SharijhaAward.Infrastructure.ExcelHelper;
using NPOI.SS.Extractor;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Features.Event.Queries.ExportToExcel;
using SelectPdf;
using PdfSharpCore.Pdf.Content.Objects;
using System.Xml;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IExcelHelper<EventsExportVM> _excelHelper;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        public EventController(IMediator Mediator, 
            IWebHostEnvironment webHostEnvironment,
            IExcelHelper<EventsExportVM> excelHelper)
        {
            _Mediator = Mediator;
            _WebHostEnvironment = webHostEnvironment;
            _excelHelper = excelHelper;
        }
        [HttpPost(Name = "AddEvent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CreateEventCommandResponse>> Create([FromBody] CreateEventCommand CreateEventCommand)
        {
            CreateEventCommandResponse? Response = await _Mediator.Send(CreateEventCommand);
            return Ok(
                      new
                      {
                          data = Response,
                          message = "تم إنشاء الفعالية بنجاح"
                      });
        }


        [HttpPut(Name = "UpdateEvent")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateEventCommand updateEventCommand)
        {
           var response= await _Mediator.Send(updateEventCommand);
            return Ok(new {data = response , message= "Updated Sucssesfully"});
        }

        [HttpGet(Name = "GetAllEvents")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllEvents(int page, int perPage)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            int pageSize = perPage == 0 ? 10 : perPage;
            //get data from mediator
            var dto = await _Mediator.Send(new GetAllEventsQuery() 
            { 
                lang = headerValue,
                page=page,
                pageSize = pageSize
            });
           
            var totalCount = dto.Count;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / pageSize);
            return Ok(
                new
                {
                    data = dto,
                    message = "Retrieved successfully.",
                    status = true,
                    pagination =
                    new
                    {
                        current_page = page,
                        last_page = totalPage,
                        total_row = totalCount,
                        per_page = pageSize
                    }
                });
        }
       
        [HttpDelete(Name = "DeleteEvent")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteEvent(Guid id)
        {
            var dtos = await _Mediator.Send(new DeleteEventCommand() { Id = id });
           
            return Ok("Delete Success");
        }

        [HttpGet("{Id}", Name = "GetEventById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetEventById(Guid id)
        { 
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";
            var Event = await _Mediator.Send(new GetEventByIdQuery() 
            {
                Id = id,
                lang=headerValue
            });

            return Ok(new { data = Event });
         
        }
        [HttpGet("GetEventWithInvitees/{id}", Name = "GetEventWithInvitees")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetEventWithInvitees(Guid id)
        {
            var response = await _Mediator.Send(new GetEventWithInviteesQuery() { Id = id });
            return Ok(new { data = response });
        }
        [HttpGet("DownloadQRCode")]
        public IActionResult DownloadQRCode(string QRCodeName)
        {
            string QRImagePath = _WebHostEnvironment.WebRootPath + "\\Images\\" + QRCodeName;

            if (!System.IO.File.Exists(QRImagePath)) return NotFound();

            byte[] QRCodeBytes = System.IO.File.ReadAllBytes(QRImagePath);
            using (MemoryStream pngStream = new MemoryStream(QRCodeBytes))
            {
                Document pdfDocument = new Document();

                Page page = pdfDocument.Pages.Add();
                page.SetPageSize(PageSize.A4.Width, PageSize.A4.Height);

                Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                image.ImageStream = new MemoryStream(QRCodeBytes);

                double centerX = page.Rect.Width / 2;
                double centerY = page.Rect.Height / 2;

                double xPosition = centerX - image.FixWidth / 2;
                double yPosition = centerY - image.FixHeight / 2;

                image.Margin = new MarginInfo 
                { 
                    Top = (centerX - image.FixWidth) / 2,
                    Bottom = (centerX - image.FixWidth) / 2,
                    Left = (centerX - image.FixHeight) / 2,
                    Right = (centerX - image.FixHeight) / 2
                };

                page.Paragraphs.Add(image);

                using (MemoryStream pdfStream = new MemoryStream())
                {
                    pdfDocument.Save(pdfStream);

                    return File(pdfStream.ToArray(), "application/pdf", "QRCode.pdf");
                }
            }
        }
        [HttpGet("DownloadBarCode")]
        public IActionResult DownloadBarCode(string BarCodeName)
        {
            if (BarCodeName.Contains('%'))
            {
                List<string> ttt = BarCodeName.Split("BarCodeFor").ToList();
                BarCodeName = "BarCodeFor" + ttt.LastOrDefault();
            }

            string BarCodeImagePath = _WebHostEnvironment.WebRootPath + "\\GeneratedBarcode\\" + BarCodeName;

            if (!System.IO.File.Exists(BarCodeImagePath)) return NotFound();

            byte[] BarCodeBytes = System.IO.File.ReadAllBytes(BarCodeImagePath);
            using (MemoryStream PNGStream = new MemoryStream(BarCodeBytes))
            {
                Document PDFDocument = new Document();

                Page Page = PDFDocument.Pages.Add();
                Page.SetPageSize(PageSize.A4.Width, PageSize.A4.Height);

                Aspose.Pdf.Image image = new Aspose.Pdf.Image();
                image.ImageStream = new MemoryStream(BarCodeBytes);

                double centerX = Page.Rect.Width;
                double centerY = Page.Rect.Height;

                double xPosition = centerX - image.FixWidth;
                double yPosition = centerY - image.FixHeight;

                image.Margin = new MarginInfo
                {
                    Top = (centerX - image.FixWidth) / 16,
                    Bottom = (centerX - image.FixWidth) / 16,
                    Left = (centerX - image.FixHeight) / 16,
                    Right = (centerX - image.FixHeight) / 16
                };

                Page.Paragraphs.Add(image);

                using (MemoryStream pdfStream = new MemoryStream())
                {
                    PDFDocument.Save(pdfStream);

                    return File(pdfStream.ToArray(), "application/pdf", "BarCode.pdf");
                }
            }
        }
        [HttpGet("DownloadTempletAsPdf")]
        public IActionResult DownloadTempletAsPdf(string htmlFile)
        {
            string Path = _WebHostEnvironment.WebRootPath + "\\HTMLCodes\\" + htmlFile;
            string HTML = System.IO.File.ReadAllText(Path);
            HTML = HTML.Replace("StrTag", "<").Replace("EndTag", ">");

            HTML = HTML
                .Replace("<td colspan=\"3\" style=\"padding: 20px\">",
                    "<td colspan=\"3\">")
                .Replace("<td colspan=\"3\">",
                    "<td colspan=\"3\" style=\"padding-left:20%\">");

            List<string> HTMLSpliter = HTML.Split("<!--100% Here-->").ToList();

            if (HTML.Contains("هذا"))
                HTML = HTMLSpliter[0] + "<table style = \"width : 100%; margin-left: auto; margin-right: auto; direction: rtl\">" + HTMLSpliter[2];
            else
                HTML = HTMLSpliter[0] + "<table style = \"width : 100%; margin-left: auto; margin-right: auto; direction: ltr\">" + HTMLSpliter[2];

            HtmlToPdf oHtmlToPdf = new HtmlToPdf();
            PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(HTML);

            byte[] pdf = oPdfDocument.Save();
            oPdfDocument.Close();

            return File(pdf, "application/pdf", $"Sharjah-Award-Invitation.pdf");
        }
        [HttpGet("ExportToExcel")]
        public async Task<FileResult> ExportToExcel()
        {
            var EventsList =await _Mediator.Send(new ExportToExcelQuery());
            var file = _excelHelper.ExportToExcel(EventsList);
            return File(file, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Events.xlsx");
        }
    }
}
