using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Queries.GetAllImageCards;
using SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageBySlug
{
    public class GetPageBySlugQueryHandler
        : IRequestHandler<GetPageBySlugQuery, BaseResponse<PageDto>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        private readonly IAsyncRepository<PageStructureImages> _PageStructureImagesRepository;
        private readonly IAsyncRepository<PageCard> _PageCardRepository;
        private readonly IAsyncRepository<ImageCard> _ImageCardRepository;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetPageBySlugQueryHandler(IAsyncRepository<PageStructure> _PageStructureRepository,
            IAsyncRepository<PageStructureImages> _PageStructureImagesRepository,
            IAsyncRepository<PageCard> _PageCardRepository,
            IAsyncRepository<ImageCard> _ImageCardRepository,
            IMapper _Mapper,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._PageStructureRepository = _PageStructureRepository;
            this._PageStructureImagesRepository = _PageStructureImagesRepository;
            this._PageCardRepository = _PageCardRepository;
            this._ImageCardRepository = _ImageCardRepository;
            this._Mapper = _Mapper;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<PageDto>> Handle(GetPageBySlugQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PageStructure? PageStructureEntity = await _PageStructureRepository
                .FirstOrDefaultAsync(x => x.Slug == Request.Slug);

            if (PageStructureEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Page structure is not found"
                    : "بناء الصفحة غير موجود";

                return new BaseResponse<PageDto>(ResponseMessage, false, 404);
            }

            List<PageCard> AllPageCardEntities = await _PageCardRepository
                .Where(x => x.PageId == PageStructureEntity.Id)
                .ToListAsync();

            List<Component> DarkCardsList = AllPageCardEntities
                .Where(x => x.CardType == CardType.DarkCard)
                .Select(x => new Component()
                {
                    CardType = CardType.DarkCard.ToString(),
                    orderId = x.orderId,
                    IsHide = x.IsHide,
                    Card = new DarkCardListVM()
                    {
                        Id = x.Id,
                        ArabicContent = !string.IsNullOrEmpty(x.ArabicContent) ? x.ArabicContent : string.Empty,
                        EnglishContent = !string.IsNullOrEmpty(x.EnglishContent) ? x.EnglishContent : string.Empty,
                        Content = Request.lang == "en"
                            ? (!string.IsNullOrEmpty(x.EnglishContent) ? x.EnglishContent : string.Empty)
                            : (!string.IsNullOrEmpty(x.ArabicContent) ? x.ArabicContent : string.Empty),
                        ArabicTitle = !string.IsNullOrEmpty(x.ArabicTitle) ? x.ArabicTitle : string.Empty,
                        EnglishTitle = !string.IsNullOrEmpty(x.EnglishTitle) ? x.EnglishTitle : string.Empty,
                        Title = Request.lang == "en"
                            ? (!string.IsNullOrEmpty(x.EnglishTitle) ? x.EnglishTitle : string.Empty)
                            : (!string.IsNullOrEmpty(x.ArabicTitle) ? x.ArabicTitle : string.Empty),
                        CardType = CardType.DarkCard,
                        IsHide = x.IsHide,
                        orderId = x.orderId
                    },
                    Goals = null
                }).ToList();

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string WWWRootFilePath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

            List<Component> ParagraphCardsList = AllPageCardEntities
                .Where(x => x.CardType == CardType.ParagraphCard)
                .Select(x => new Component()
                {
                    CardType = CardType.ParagraphCard.ToString(),
                    orderId = x.orderId,
                    IsHide = x.IsHide,
                    Card = new ParagraphCardListVM()
                    {
                        Id = x.Id,
                        ArabicContent = x.ArabicContent,
                        EnglishContent = x.EnglishContent,
                        Content = Request.lang == "en"
                            ? x.EnglishContent
                            : x.ArabicContent,
                        ArabicTitle = x.ArabicTitle,
                        EnglishTitle = x.EnglishTitle,
                        Title = Request.lang == "en"
                            ? x.EnglishTitle
                            : x.ArabicTitle,
                        CardType = CardType.ParagraphCard,
                        ImageInStart = x.ImageInStart,
                        ImageUrl = (!string.IsNullOrEmpty(x.ImageUrl)
                            ? (x.ImageUrl.Contains("wwwroot")
                                ? (WWWRootFilePath + x.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.ImageUrl).Replace("\\", "/")
                            : null),
                        IsHide = x.IsHide,
                        orderId = x.orderId,
                        PageId = x.PageId
                    },
                    Goals = null
                }).ToList();

            List<ImageCard> ImageCardEntities = await _ImageCardRepository
                .Where(x => x.PageId == PageStructureEntity.Id)
                .ToListAsync();

            IEnumerable<PageStructureImages> PageStructureImagesEntities = await _PageStructureImagesRepository
                .Where(x => ImageCardEntities.Select(y => y.Id).Contains(x.ImageCardId))
                .ToListAsync();

            List<Component> ImageCardsList = ImageCardEntities
                .Where(x => x.PageId == PageStructureEntity.Id)
                .Select(x => new Component()
                {
                    CardType = CardType.ImageCard.ToString(),
                    orderId = x.orderId,
                    IsHide = x.IsHide,
                    Card = new ImageCardListVM()
                    {
                        Id = x.Id,
                        IsHide = x.IsHide,
                        orderId = x.orderId,
                        CardImages = PageStructureImagesEntities
                            .Where(y => y.ImageCardId == x.Id)
                            .Select(y => new PageImageDto()
                            {
                                Id = y.Id,
                                ImageId = y.ImageCardId,
                                ImageUrl = (y.ImageUrl.Contains("wwwroot")
                                    ? (WWWRootFilePath + y.ImageUrl.Split("wwwroot")[1]).Replace("\\", "/")
                                    : y.ImageUrl).Replace("\\", "/"),
                            }).ToList(),
                    },
                    Goals = null
                }).ToList();

            List<Component> TextCardsList = AllPageCardEntities
                .Where(x => x.CardType == CardType.TextCard)
                .Select(x => new Component()
                {
                    CardType = CardType.TextCard.ToString(),
                    orderId = x.orderId,
                    IsHide = x.IsHide,
                    Card = new TextCardListVM()
                    {
                        Id = x.Id,
                        ArabicContent = x.ArabicContent,
                        EnglishContent = x.EnglishContent,
                        Content = Request.lang == "en"
                            ? x.EnglishContent
                            : x.ArabicContent,
                        orderId = x.orderId,
                        IsHide = x.IsHide,
                        CardType = CardType.TextCard,
                        PageStructureId = x.PageId
                    },
                    Goals = null
                }).ToList();

            PageDto Response = _Mapper.Map<PageDto>(PageStructureEntity);

            Response.IconUrl = !string.IsNullOrEmpty(Response.IconUrl)
                ? (Response.IconUrl.Contains("wwwroot")
                    ? (WWWRootFilePath + Response.IconUrl.Split("wwwroot")[1]).Replace("\\", "/")
                    : Response.IconUrl.Replace("\\", "/"))
                : null;

            if (Request.lang == "en")
            {
                Response.Title = Response.EnglishTitle;
                Response.SubTitle = Response.EnglishSubTitle;
                Response.Content = Response.EnglishContent;
            }
            else
            {
                Response.Title = Response.ArabicTitle;
                Response.SubTitle = Response.ArabicSubTitle;
                Response.Content = Response.ArabicContent;
            }

            Response.numberOfSubPages = await _PageStructureRepository
                .GetCountAsync(x => x.ParentId == PageStructureEntity.Id);

            Response.Components = DarkCardsList
                .Concat(ParagraphCardsList)
                .Concat(ImageCardsList)
                .Concat(TextCardsList)
                .ToList();

            List<PageCard> GoalCardsList = AllPageCardEntities
                .Where(x => x.CardType == CardType.GoalCard)
                .ToList();

            if (GoalCardsList.Any())
            {
                IEnumerable<PageCard> MainGoalCards = GoalCardsList
                    .Where(x => x.ParentId == null);

                foreach (PageCard MainGoalCard in MainGoalCards)
                {
                    Response.Components.Add(new Component()
                    {
                        CardType = CardType.GoalCard.ToString(),
                        orderId = MainGoalCard.orderId,
                        IsHide = MainGoalCard.IsHide,
                        Goals = new MainGoalCardData()
                        {
                            ArabicTitle = MainGoalCard.ArabicTitle,
                            EnglishTitle = MainGoalCard.EnglishTitle,
                            Title = Request.lang == "en"
                                ? MainGoalCard.EnglishTitle
                                : MainGoalCard.ArabicTitle,
                            IsHide = MainGoalCard.IsHide,
                            PageId = MainGoalCard.PageId,
                            orderId = MainGoalCard.orderId,
                            Id = MainGoalCard.Id,
                            SubGoals = GoalCardsList
                                .Where(x => x.ParentId == MainGoalCard.Id)
                                .Select(x => new GoalCardListVM()
                                {
                                    Id = x.Id,
                                    IsHide = x.IsHide,
                                    ArabicContent = x.ArabicContent,
                                    EnglishContent = x.EnglishContent,
                                    orderId = x.orderId,
                                    PageId = MainGoalCard.PageId,
                                    Content = Request.lang == "en"
                                        ? x.EnglishContent
                                        : x.ArabicContent,
                                    CardType = CardType.GoalCard
                                }).ToList()
                        }
                    });
                }
            }

            Response.Components = Response.Components
                .OrderBy(x => x.orderId)
                .ToList();

            return new BaseResponse<PageDto>(ResponseMessage, true, 200, Response);
        }
    }
}
