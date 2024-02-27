using Aspose.Pdf.Operators;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ;
using SharijhaAward.Application.Features.FAQs.Commands.UpdateFAQ;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Features.FAQs.Queries.GetFAQById;

namespace SharijhaAward.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FAQController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FAQController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateFAQ")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> CreateFAQ(CreateFAQCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(
                new
                {
                    data = response,
                    message = "تم إنشاء سؤال شائع بنجاح"
                });
        }

        [HttpPut(Name = "UpdateFAQ")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateFAQ([FromBody] UpdateFAQCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(
               new
               {
                   data = response,
                   message = "تم تعديل السؤال الشائع بنجاح"
               });
        }

        [HttpDelete(Name = "DeleteFAQ")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteFAQ(Guid Id)
        { 
            var response = await _mediator.Send(new DeleteFAQCommand() {Id=Id });
            return Ok(
               new
               {
                   data = response,
                   message = "تم حذف السؤال الشائع بنجاح"
               });
        }

        [HttpGet("{Id}",Name="GetFAQById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetFAQById(Guid Id)
        {
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            var response = await _mediator.Send(new GetFAQByIdQuery()
            {
                Id = Id,
                lang = headerValue!
            });

            return Ok(
                new
                { 
                    data = response,
                    message = "تم إسترجاع السؤال بنجاح"
                });
        }

        [HttpGet(Name ="GetAllFAQs")]
        public async Task<ActionResult> GetAllFAQs(int perPage, int page)
        {
            //get Language from header
            var headerValue = HttpContext.Request.Headers["lang"];
            if (headerValue.IsNullOrEmpty())
                headerValue = "";

            //get data from mediator
            var response = await _mediator.Send(new GetAllFAQsQuery() 
            {
                lang = headerValue!,
                page = page,
                pageSize = perPage
                
            });

            if(response.statusCode == 404)
            {
                return NotFound(new
                {
                    response.message,
                    response.statusCode,
                    response.success
                });
            }
            else if(response.statusCode == 200)
            {
                var totalCount = response.data!.Count;
                var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

                return Ok(
                new
                {
                        response.data,
                        response.message,
                        response.statusCode,
                        pagination =
                        new
                        {
                            current_page = page,
                            last_page = page - 1,
                            total_row = totalCount,
                            per_page = perPage,
                            totalPage = totalPage
                        }
                });
            }
            else return BadRequest(new { response });
            
        }
    }
}
