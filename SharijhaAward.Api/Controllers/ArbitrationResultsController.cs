using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SelectPdf;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.ArbitrationResults.Commands.ChangeArbitrationResultsStatus;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.ExportArbitrationResultsToExcel;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults;
using SharijhaAward.Application.Features.ArbitrationResults.Queries.GetCertificationByFormId;
using SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.TemplateModel;
using SharijhaAward.Persistence;
using System.IO.Compression;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class ArbitrationResultsController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;
        private readonly SharijhaAwardDbContext _SharijhaAwardDbContext;
        private readonly HttpClient _HttpClient;
        public ArbitrationResultsController(IMediator Mediator,
            IWebHostEnvironment _WebHostEnvironment,
            SharijhaAwardDbContext _SharijhaAwardDbContext,
            HttpClient _HttpClient)
        {
            _Mediator = Mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
            this._SharijhaAwardDbContext = _SharijhaAwardDbContext;
            this._HttpClient = _HttpClient;
        }
        [HttpGet("GetAllArbitrationResults")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllArbitrationResults([FromQuery] List<Filter>? filters,
            int? CategoryId, string? SubscriberName,
            int? CycleNumber, string? CategoryName, bool? EligibleToWin, EligableFilter? EligableFilter, int Page = 1, int PerPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            StringValues? Token = HttpContext.Request.Headers.Authorization;

            if (string.IsNullOrEmpty(Token))
                return Unauthorized("You must send the token");

            BaseResponse<List<GetAllArbitrationResultsListVM>> Response = await _Mediator.Send(new GetAllArbitrationResultsQuery()
            {
                CategoryId = CategoryId,
                lang = HeaderValue!,
                page = Page,
                PerPage = PerPage,
                SubscriberName = SubscriberName,
                CycleNumber = CycleNumber,
                CategoryName = CategoryName,
                EligibleToWin = EligibleToWin,
                Token = Token,
                filters = filters,
                EligableFilter = EligableFilter
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPut("ChangeArbitrationResultsStatus")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> ChangeArbitrationResultsStatus([FromBody] ChangeArbitrationResultsStatusCommand ChangeArbitrationResultsStatusCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            ChangeArbitrationResultsStatusCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            ChangeArbitrationResultsStatusCommand.ImagePath = _WebHostEnvironment.WebRootPath;

            BaseResponse<object>? Response = await _Mediator.Send(ChangeArbitrationResultsStatusCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ArbitrationResultsExportToExcel", Name = "ArbitrationResultsExportToExcel")]
        public async Task<IActionResult> ArbitrationResultsExportToExcel()
        {
            var response = await _Mediator.Send(new ExportArbitrationResultsToExcelQuery());

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => File(response.data!, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ArbitrationResults.xlsx"),
                _ => BadRequest(response)
            };
        }
        [HttpGet("GetCertificationByFormId/{FormId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetCertificationByFormId(int FormId)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetCertificationByFormIdDto> Response = await _Mediator.Send(new GetCertificationByFormIdQuery()
            {
                FormId = FormId,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("DownloadCertificateAsPdf")]
        public IActionResult DownloadCertificateAsPdf(int FormId)
        {
            var SavedCertificates = _SharijhaAwardDbContext
                .SavedCertificates
                .Where(x => x.ProvidedFormId == FormId)
                .Select(x => new
                {
                    FileName = Path.GetFileName(x.FilePath),
                    TemplateType = (TemplateTypes)x.TemplateType
                })
                .ToList();

            using (var zipMemoryStream = new MemoryStream())
            {
                using (var archive = new ZipArchive(zipMemoryStream, ZipArchiveMode.Create, true))
                {
                    foreach (var SavedCertificate in SavedCertificates)
                    {
                        string Path2 = string.Empty;

                        string basePath = Path.Combine(Directory.GetCurrentDirectory(), "SavedCertificates");

                        Path2 = Path.Combine(basePath, "ParticipationCertificates", SavedCertificate.FileName);

                        if (SavedCertificate.TemplateType == TemplateTypes.CertificateOfParticipation)
                        {
                            Path2 = Path2 + "/ParticipationCertificates/" + SavedCertificate.FileName;
                        }
                        else if (SavedCertificate.TemplateType == TemplateTypes.Testimonial_Version_1)
                        {
                            Path2 = Path2 + "/Statment1Certificates/" + SavedCertificate.FileName;
                        }
                        else if (SavedCertificate.TemplateType == TemplateTypes.Testimonial_Version_2)
                        {
                            Path2 = Path2 + "/Statment2Certificates/" + SavedCertificate.FileName;
                        }
                        else if (SavedCertificate.TemplateType == TemplateTypes.Evaluation_Form)
                        {
                            Path2 = Path2 + "/EvaluationFormCertificates/" + SavedCertificate.FileName;
                        }


                        if (!System.IO.File.Exists(Path2))
                        {
                            throw new FileNotFoundException($"The file at path {Path2} does not exist.");
                        }

                        string HTML = System.IO.File.ReadAllText(Path2);

                        HtmlToPdf oHtmlToPdf = new HtmlToPdf();
                        PdfDocument oPdfDocument = oHtmlToPdf.ConvertHtmlString(HTML);

                        byte[] pdf = oPdfDocument.Save();
                        oPdfDocument.Close();

                        // Add the PDF file to the ZIP archive
                        var pdfFileEntry = archive.CreateEntry(SavedCertificate.FileName);
                        using (var entryStream = pdfFileEntry.Open())
                        {
                            entryStream.Write(pdf, 0, pdf.Length);
                        }
                    }

                    // Set the position to the beginning of the memory stream
                    zipMemoryStream.Seek(0, SeekOrigin.Begin);

                    // Return the zip file
                    return File(zipMemoryStream.ToArray(), "application/zip", "Sharjah-Award-Certificates.zip");
                }
            }
        }
    }
}
