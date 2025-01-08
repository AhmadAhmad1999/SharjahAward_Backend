using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.CreateImageCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.CreateParagraphCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage
{
    public class CreatePageCommandHandler
        : IRequestHandler<CreatePageCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<PageCard> _PageCardRepository;
        private readonly IAsyncRepository<ImageCard> _ImageCardRepository;
        private readonly IAsyncRepository<PageStructureImages> _PageStructureImagesRepository;

        public CreatePageCommandHandler(IAsyncRepository<PageStructure> _PageStructureRepository, 
            IFileService _FileService, 
            IMapper _Mapper,
            IAsyncRepository<PageCard> _PageCardRepository,
            IAsyncRepository<ImageCard> _ImageCardRepository,
            IAsyncRepository<PageStructureImages> _PageStructureImagesRepository)
        {
            this._PageStructureRepository = _PageStructureRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._PageCardRepository = _PageCardRepository;
            this._ImageCardRepository = _ImageCardRepository;
            this._PageStructureImagesRepository = _PageStructureImagesRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreatePageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (Request.ParentId is not null)
            {
                PageStructure? ParentPageStructure = await _PageStructureRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.ParentId);

                if (ParentPageStructure is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Parent page is not found"
                        : "الصفحة الأب غير موجودة";

                    return new BaseResponse<int>(ResponseMessage, false, 404);
                }
            }

            List<PageStructure> CellPages = await _PageStructureRepository
                .Where(x => x.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
                .ToListAsync();

            if (Request.PageType != Domain.Constants.PageType.MainPageWithoutSubPage && 
                Request.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This page cannot be added to cells"
                    : "لا يمكن إضافة هذه الصفحة الى الخلايا";

                return new BaseResponse<int>(ResponseMessage, false, 400);
            }

            if (CellPages.Count() >= 5 && Request.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
            {
                ResponseMessage = Request.lang == "en"
                    ? "No more than five pages can be added to cells."
                    : "لا يمكن إضافة أكثر من خمسة صفحات إلى الخلايا";

                return new BaseResponse<int>(ResponseMessage, false, 400);
            }

            PageStructure NewPageStructure = _Mapper.Map<PageStructure>(Request);
            
            if (NewPageStructure.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
            {
                PageStructure? LastPageStructureEntity = await _PageStructureRepository
                    .OrderBy(x => x.orderId)
                    .LastOrDefaultAsync(x => x.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells);

                if (LastPageStructureEntity is not null)
                    NewPageStructure.orderId = LastPageStructureEntity.orderId + 1;
            }
            else
            {
                PageStructure? LastPageStructureEntity = await _PageStructureRepository
                    .OrderBy(x => x.orderId)
                    .LastOrDefaultAsync(x => x.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InMenu);

                if (LastPageStructureEntity is not null)
                    NewPageStructure.orderId = LastPageStructureEntity.orderId + 1;
            }

            NewPageStructure.Deletable = true;

            if (Request.Icon != null)
                NewPageStructure.IconUrl = await _FileService.SaveFileAsync(Request.Icon, SystemFileType.Icons);

            NewPageStructure.Slug = Request.Slug == null
                ? Request.EnglishTitle.Replace(" ", "_").ToLower()
                : Request.Slug.Replace(" ", "_").ToLower();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    PageStructure NewPageStructureEntity = await _PageStructureRepository.AddAsync(NewPageStructure);

                    List<PageCard> NewPageCards =
                    [
                        .. Request.DarkCardRequest
                            .Select(x => new PageCard()
                            {
                                orderId = x.orderId,
                                EnglishTitle = x.EnglishTitle,
                                ArabicTitle = x.ArabicTitle,
                                EnglishContent = x.EnglishContent,
                                ArabicContent = x.ArabicContent,
                                IsHide = x.IsHide,
                                CardType = CardType.DarkCard,
                                PageId = NewPageStructureEntity.Id
                            }),
                    ];

                    foreach (CreateParagraphCardCommand ParagraphCardRequest in Request.ParagraphCardRequest)
                    {
                        NewPageCards.Add(new PageCard()
                        {
                            orderId = ParagraphCardRequest.orderId,
                            EnglishTitle = ParagraphCardRequest.EnglishTitle,
                            ArabicTitle = ParagraphCardRequest.ArabicTitle,
                            EnglishContent = ParagraphCardRequest.EnglishContent,
                            ArabicContent = ParagraphCardRequest.ArabicContent,
                            IsHide = ParagraphCardRequest.IsHide,
                            CardType = CardType.ParagraphCard,
                            PageId = NewPageStructureEntity.Id,
                            ImageInStart = ParagraphCardRequest.ImageInStart,
                            ImageUrl = ParagraphCardRequest.Image is not null
                                ? await _FileService.SaveFileAsync(ParagraphCardRequest.Image!, SystemFileType.Images)
                                : null
                        });
                    }

                    foreach (CreateGoalCardCommand GoalCardRequest in Request.GoalCardRequest)
                    {
                        PageCard NewGoalCard = new PageCard()
                        {
                            EnglishTitle = GoalCardRequest.EnglishTitle,
                            ArabicTitle = GoalCardRequest.ArabicTitle,
                            PageId = NewPageStructureEntity.Id,
                            IsHide = GoalCardRequest.IsHide,
                            CardType = CardType.GoalCard,
                            orderId = GoalCardRequest.orderId
                        };

                        await _PageCardRepository.AddAsync(NewGoalCard);

                        NewPageCards.AddRange(GoalCardRequest
                            .SubGoals
                            .Select(x => new PageCard()
                            {
                                orderId = x.orderId,
                                ArabicContent = x.ArabicContent,
                                EnglishContent = x.EnglishContent,
                                IsHide = x.IsHide,
                                CardType = CardType.GoalCard,
                                PageId = NewPageStructureEntity.Id,
                                ParentId = NewGoalCard.Id
                            }));
                    }

                    foreach (CreateImageCardCommand ImageCardRequest in Request.ImageCardRequest)
                    {
                        ImageCard NewImageCardEntity = _Mapper.Map<ImageCard>(ImageCardRequest);
                        
                        NewImageCardEntity.PageId = NewPageStructureEntity.Id;

                        await _ImageCardRepository.AddAsync(NewImageCardEntity);

                        if (ImageCardRequest.CardImages.Any())
                        {
                            List<PageStructureImages> NewPageStructureImagesEntities = new List<PageStructureImages>();

                            foreach (IFormFile CardImage in ImageCardRequest.CardImages)
                            {
                                NewPageStructureImagesEntities.Add(new PageStructureImages()
                                {
                                    ImageUrl = await _FileService.SaveFileAsync(CardImage, SystemFileType.Images),
                                    ImageCardId = NewImageCardEntity.Id
                                });
                            }

                            await _PageStructureImagesRepository.AddRangeAsync(NewPageStructureImagesEntities);
                        }
                    }

                    if (Request.TextCardRequest.Any())
                        NewPageCards.AddRange(Request.TextCardRequest
                            .Select(x => new PageCard()
                            {
                                orderId = x.orderId,
                                EnglishContent = x.EnglishContent,
                                IsHide = x.IsHide,
                                ArabicContent = x.ArabicContent,
                                PageId = NewPageStructureEntity.Id,
                                CardType = CardType.TextCard
                            }));

                    await _PageCardRepository.AddRangeAsync(NewPageCards);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الصفحة بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewPageStructureEntity.Id);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
