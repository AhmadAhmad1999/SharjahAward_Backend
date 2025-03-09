using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using SharijhaAward.Api.Logger;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPage;
using SharijhaAward.Application.Features.AboutAwardPages.Queries.GetAboutPageWebSite;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetVirtualTableById;
using SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd;
using SharijhaAward.Application.Features.Agendas.Queries.GetAgendaByCycleId;
using SharijhaAward.Application.Features.Agendas.Queries.GetAllAgenda;
using SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries;
using SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums;
using SharijhaAward.Application.Features.AppVersioningFeatures.Query.GetAllLastVersionsForAllTypes;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAllAwardPublications;
using SharijhaAward.Application.Features.AwardPublications.Queries.GetAwardPublicationById;
using SharijhaAward.Application.Features.AwardSponsorsPage.Queries.GetAwardSponsor;
using SharijhaAward.Application.Features.AwardStatistics.Queries.GetAllAwardStatistics;
using SharijhaAward.Application.Features.Categories.Queries.GetAllCategories;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.GetInitalQuestions;
using SharijhaAward.Application.Features.ChatBotQuestions.Queries.TalkWithChatBot;
using SharijhaAward.Application.Features.ContactUsPages.Commands.CreateMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Features.Event.Queries.GetEventById;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;
using SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory;
using SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems;
using SharijhaAward.Application.Features.InviteeForm.Group.Queries.GetAllGroupInvitees;
using SharijhaAward.Application.Features.InviteeForm.Personal.Queries.GetAllPersonalInvitee;
using SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Features.News.Queries.GetNewsByCycleId;
using SharijhaAward.Application.Features.News.Queries.GetNewsById;
using SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetAllNewsTicker;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetMainPagesWithSubPages;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPagesInCell;
using SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage;
using SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy;
using SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse;
using SharijhaAward.Application.Features.SocialMediaPage.Queries.GetAllSocialMediaItems;
using SharijhaAward.Application.Features.StrategicPartners.Queries.GetAllStrategicPartners;
using SharijhaAward.Application.Features.WinnersFeatures.Queries.GetAllWinnersForWebsite;
using SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValue;
using SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Api.Controllers
{
    [ServiceFilter(typeof(LogFilterAttribute))]
    [Route("api/[controller]")]
    [ApiController]
    public class WebsiteController : ControllerBase
    {
        private readonly IMediator _Mediator;
        private readonly IWebHostEnvironment _WebHostEnvironment;

        public WebsiteController(IMediator Mediator,
            IWebHostEnvironment _WebHostEnvironment)
        {
            _Mediator = Mediator;
            this._WebHostEnvironment = _WebHostEnvironment;
        }

        [HttpGet("ChatBot/GetInitialQuestions")]
        public async Task<IActionResult> GetInitialQuestions()
        {
            var lang = HttpContext.Request.Headers["lang"];

            var Response = await _Mediator.Send(new GetInitialQuestionsQuery()
            {
                lang = lang!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("ChatBot/TalkWithChatBot")]
        public async Task<IActionResult> TalkWithChatBot([FromQuery] int QuestionId)
        {
            var lang = HttpContext.Request.Headers["lang"];

            var Response = await _Mediator.Send(new TalkWithChatBotQuery()
            {
                QuestionId = QuestionId,
                lang = lang!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("AboutPage/GetAboutPageWebSite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAboutPageWebSite()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AboutPageDto> Response = await _Mediator.Send(new GetAboutPageWebSiteQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Agenda/GetAgendasByCycleId")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAgendasByCycleId(int? Id, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<AgendaListVm>> Response = await _Mediator.Send(new GetAgendaByCycleIdQuery()
            {
                page = page,
                perPage = perPage,
                CycleId = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Winners/GetAllWinnersForWebsite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> WebsiteGetAllWinnersForWebsite([FromQuery] GetAllWinnersForWebsiteQuery GetAllWinnersForWebsiteQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllWinnersForWebsiteQuery.lang = HeaderValue;

            BaseResponse<List<GetAllWinnersForWebsiteMainResponse>> Response = await _Mediator.Send(GetAllWinnersForWebsiteQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("StrategicPartner")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllStrategicPartners([FromQuery] GetAllStrategicPartnersQuery query)
        {
            BaseResponse<List<StrategicPartnerListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("SocialMediaItem")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllSocialMediaItem(int page = 1, int perPage = 10)
        {
            BaseResponse<List<SocialMediaItemListVM>> Response = await _Mediator.Send(new GetAllSocialMediaItemsQuery()
            {
                page = page,
                perPage = perPage
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Settings/GetTermsOfUse")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetTermsOfUse(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetTermsOfUseDto> Response = await _Mediator.Send(new GetTermsOfUseQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Settings/GetPrivacyPolicy")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPrivacyPolicy(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetPrivacyPolicyDto> Response = await _Mediator.Send(new GetPrivacyPolicyQuery()
            {
                Slug = Slug,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("ReferenceSourcePage")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetReferenceSourcePage()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<ReferenceSourceDto> Response = await _Mediator.Send(new GetReferenceSourcePageQuery
            {
                lang = HeaderValue!,
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("PersonalInvitee")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllPersonalInvitee(int page, int perPage, string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;

            BaseResponse<List<PersonalInviteeListVM>> Response = await _Mediator.Send(new GetAllPersonalInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });

            var totalCount = Response.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

            return Ok(
                new
                {
                    Response.data,
                    Response.statusCode,
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
        [HttpGet("Page/GetPageBySlug/{Slug}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPageBySlug(string Slug)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<PageDto> Response = await _Mediator.Send(new GetPageBySlugQuery()
            {
                lang = HeaderValue!,
                Slug = Slug
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("News/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetNewsById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<NewsDto> Response = await _Mediator.Send(new GetNewsByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("News/GetNewsForWebsite")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetNewsForWebsite(string? query, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<NewsListVM>> Response = await _Mediator.Send(new GetNewsForWebsiteQuery()
            {
                lang = HeaderValue!,
                page = page,
                perPage = perPage,
                query = query
            });
            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("MessageType")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllMessageType()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<MessageTypeListVM>> Response = await _Mediator.Send(new GetAllMsgQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response),
            };
        }
        [HttpGet("HomePageSlider")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllHomeSliderItems([FromQuery] GetAllHomePageSliderItemsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<SliderItemsListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GroupInvitee")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> GetAllGroupInvitee(int page, int perPage, string? name, int? EventId)
        {
            if (perPage == 0)
                perPage = 10;

            BaseResponse<List<GroupInviteeListVM>> Response = await _Mediator.Send(new GetAllGroupInviteeQuery()
            {
                EventId = EventId,
                page = page,
                perPage = perPage,
                name = name
            });

            var totalCount = Response.totalItem;
            var totalPage = (int)Math.Ceiling((decimal)totalCount / perPage);

            return Ok(
                new
                {
                    Response.data,
                    Response.statusCode,
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
        [HttpGet("GeneralFAQCategory/GetAllGeneralFAQCategories")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllGeneralFAQCategories([FromQuery] GetAllGeneralFAQCategoryQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<GetAllGeneralFAQCategoryListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Event/{Id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> WebsiteGetEventById(int id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            EventDto Response = await _Mediator.Send(new GetEventByIdQuery()
            {
                Id = id,
                lang = HeaderValue
            });

            return Ok(new { data = Response });
        }
        [HttpGet("Cycle")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCycle([FromQuery] GetAllCyclesQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<CycleListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("ContactUs")]
        public async Task<IActionResult> SendMessage([FromForm] CreateMessageCommand command)
        {
            var token = HttpContext.Request.Headers.Authorization;
            var language = HttpContext.Request.Headers["lang"];

            command.token = token!;
            command.lang = language!;

            var response = await _Mediator.Send(command);

            return response.statusCode switch
            {
                404 => NotFound(response),
                200 => Ok(response),
                401 => Unauthorized(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("ContactUs")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllMessages(string? query, int? filter, int page = 1, int perPage = 10)
        {
            StringValues Token = HttpContext.Request.Headers.Authorization;

            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<EmailMessageListVM>> Response = await _Mediator.Send(new GetAllEmailMessageQuery()
            {
                filter = filter,
                page = page,
                perPage = perPage,
                query = query,
                lang = HeaderValue!,
                token = Token!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                401 => Unauthorized(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Category/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetCategoryById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<CategoryDto> Response = await _Mediator.Send(new GetCategoryByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Category")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllCategories(int? CycleId, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<CategoryListVM>> Response = await _Mediator.Send(new GetAllCategoryQuery
            {
                lang = HeaderValue!,
                page = page,
                perPage = perPage,
                CycleId = CycleId
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardStatistic")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAwardStatistics([FromQuery] GetAllAwardStatisticsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AwardStatisticListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardSponsor")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAwardSponser()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AwardSponsorListVM> Response = await _Mediator.Send(new GetAwardSponsorQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardPublication")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAwardPublications([FromQuery] GetAllAwardPublicationsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AwardPublicationListVM>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("AwardPublication/{Id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAwardPublicationById(int Id)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<AwardPublicationDto> Response = await _Mediator.Send(new GetAwardPublicationByIdQuery()
            {
                Id = Id,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Album/GetAllGalleries/{AlbumId}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllGalleries(int AlbumId, int page = 1, int perPage = 10)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GalleryListVm>> Response = await _Mediator.Send(new GetAllGalleriesQuery()
            {
                AlbumId = AlbumId,
                lang = HeaderValue!,
                page = page,
                perPage = perPage
            });

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Album")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAlbums([FromQuery] GetAllAlbumsQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;

            BaseResponse<List<AlbumListVm>> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("Page/GetMainPagesWithSubPages")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetMainPagesWithSubPages([FromQuery] GetMainPagesWithSubPagesQuery query)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            query.lang = HeaderValue!;
            query.intoWebsite = true;

            BaseResponse<GetMainPagesWithSubPagesResponse> Response = await _Mediator.Send(query);

            return Response.statusCode switch
            {
                200 => Ok(Response),
                404 => NotFound(Response),
                _ => BadRequest(Response)
            };
        }

        [HttpGet("GetMainPages")]
        public async Task<IActionResult> GetMainPages(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new GetMainPagesQuery()
            {
                page = page,
                perPage = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("GetPagesInCell")]
        public async Task<IActionResult> GetPagesInCell(int page = 1, int perPage = 10)
        {
            var language = HttpContext.Request.Headers["lang"];

            var response = await _Mediator.Send(new GetPagesInCellQuery()
            {
                page = page,
                perPage = perPage,
                lang = language!
            });

            return response.statusCode switch
            {
                200 => Ok(response),
                404 => NotFound(response),
                _ => BadRequest(response)
            };
        }

        [HttpGet("AppsVersions/GetAllLastVersionsForAllTypes")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllLastVersionsForAllTypes()
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllLastVersionsForAllTypesListVM>> Response = await _Mediator.Send(new GetAllLastVersionsForAllTypesQuery()
            {
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetAllAdvancedFormBuilderSectionsForAdd/{PrivateHashKey}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllAdvancedFormBuilderSectionsForAdd(string PrivateHashKey)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>> Response = await _Mediator.Send(new GetAllAdvancedFormBuilderSectionsForAddQuery()
            {
                lang = HeaderValue!,
                PrivateHashKey = PrivateHashKey
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AddAdvancedFormBuilderValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddAdvancedFormBuilderValue([FromForm] AddAdvancedFormBuilderValueCommand AddAdvancedFormBuilderValueCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddAdvancedFormBuilderValueCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AddAdvancedFormBuilderValueCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/AdvancedFormsFiles/";
            BaseResponse<AddAdvancedFormBuilderValueResponse>? Response = await _Mediator.Send(AddAdvancedFormBuilderValueCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("AddAdvancedFormBuilderValueForSave")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddAdvancedFormBuilderValueForSave([FromForm] AddAdvancedFormBuilderValueForSaveCommand AddAdvancedFormBuilderValueForSaveCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddAdvancedFormBuilderValueForSaveCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AddAdvancedFormBuilderValueForSaveCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/AdvancedFormsFiles/";
            BaseResponse<int> Response = await _Mediator.Send(AddAdvancedFormBuilderValueForSaveCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("GetVirtualTableById/{PrivateHashKey}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetVirtualTableById(string PrivateHashKey)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<GetVirtualTableByIdDto> Response = await _Mediator.Send(new GetVirtualTableByIdQuery()
            {
                PrivateHashKey = PrivateHashKey,
                lang = HeaderValue!
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("DynamicAttributeSection/GetAllDynamicAttributeSectionsForAdd")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllDynamicAttributeSectionsForAdd(int? ProvidedFormId,
            int? ArbitratorId, int? CoordinatorId, bool? isArbitrator, int? EventId, InviteeTypes? InviteeType,
            int? GroupInviteeId, int? PersonalInviteeId, int? GroupInviteeNumber, int? PersonalInviteeNumber)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>> Response = await _Mediator.Send(new GetAllDynamicAttributeSectionsForAddQuery()
            {
                lang = HeaderValue!,
                ProvidedFormId = ProvidedFormId,
                ArbitratorId = ArbitratorId,
                CoordinatorId = CoordinatorId,
                isArbitrator = isArbitrator,
                EventId = EventId,
                InviteeType = InviteeType,
                GroupInviteeId = GroupInviteeId,
                PersonalInviteeId = PersonalInviteeId,
                GroupInviteeNumber = GroupInviteeNumber,
                PersonalInviteeNumber = PersonalInviteeNumber
            });

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpPost("DynamicAttribute/AddDynamicAttributeValue")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult>
            AddDynamicAttributeValue([FromForm] AddDynamicAttributeValueCommand AddDynamicAttributeValueCommand)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];
            AddDynamicAttributeValueCommand.lang = !string.IsNullOrEmpty(HeaderValue)
                ? HeaderValue
                : "en";

            AddDynamicAttributeValueCommand.WWWRootFilePath = _WebHostEnvironment.WebRootPath + "/DynamicFiles/";
            BaseResponse<AddDynamicAttributeValueResponse>? Response = await _Mediator.Send(AddDynamicAttributeValueCommand);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("NewsTickers/GetAllNewsTicker")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllNewsTicker([FromQuery] GetAllNewsTickerQuery GetAllNewsTickerQuery)
        {
            StringValues? HeaderValue = HttpContext.Request.Headers["lang"];

            if (string.IsNullOrEmpty(HeaderValue))
                HeaderValue = "en";

            GetAllNewsTickerQuery.lang = HeaderValue!;

            BaseResponse<List<GetAllNewsTickerListVM>> Response = await _Mediator.Send(GetAllNewsTickerQuery);

            return Response.statusCode switch
            {
                404 => NotFound(Response),
                200 => Ok(Response),
                _ => BadRequest(Response)
            };
        }
        [HttpGet("ExplanatoryGuide/{Id}", Name = "ExplanatoryGuide")]
        public async Task<IActionResult> GetExplanatoryGuideByCategoryId(int Id)
        {
            //get Language from header
            var Language = HttpContext.Request.Headers["lang"];
            var response = await _Mediator.Send(new GetExplanatoryGuideByCategoryIdQuery()
            {
                CategoryId = Id,
                lang = Language!
            });
            return response.statusCode switch
            {
                // Return the file as a downloadable response
                200 => File(response.data!.fileContent, "application/pdf", response.data.fileFileName),
                404 => NotFound(response),
                _ => BadRequest(response)
            };

        }
    }
}
