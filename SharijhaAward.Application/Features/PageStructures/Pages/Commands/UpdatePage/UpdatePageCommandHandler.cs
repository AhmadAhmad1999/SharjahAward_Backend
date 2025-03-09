using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.UpdateGoalCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.UpdateParagraphCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.UpdateTextCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.PageStructureModel;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage
{
    public class UpdatePageCommandHandler
        : IRequestHandler<UpdatePageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        private readonly IAsyncRepository<PageCard> _PageCardRepository;
        private readonly IFileService _FileService;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<ImageCard> _ImageCardRepository;
        private readonly IAsyncRepository<PageStructureImages> _PageStructureImagesRepository;

        public UpdatePageCommandHandler(IAsyncRepository<PageStructure> _PageStructureRepository,
            IAsyncRepository<PageCard> _PageCardRepository,
            IFileService _FileService,
            IMapper _Mapper,
            IAsyncRepository<ImageCard> _ImageCardRepository,
            IAsyncRepository<PageStructureImages> _PageStructureImagesRepository)
        {
            this._PageStructureRepository = _PageStructureRepository;
            this._PageCardRepository = _PageCardRepository;
            this._FileService = _FileService;
            this._Mapper = _Mapper;
            this._ImageCardRepository = _ImageCardRepository;
            this._PageStructureImagesRepository = _PageStructureImagesRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdatePageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PageStructure? PageStructure = await _PageStructureRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (PageStructure is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Page structure is not found"
                    : "بناء الصفحة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            string? Icon = PageStructure.IconUrl;

            List<PageStructure> PageStructureEntitiesInCells = await _PageStructureRepository
                .Where(p => p.PagePostion == Domain.Constants.CustomPageConstants.PagePostion.InCells)
                .ToListAsync();

            _Mapper.Map(Request, PageStructure, typeof(UpdatePageCommand), typeof(PageStructure));

            if (Request.UpdateOnIcon is not null && 
                (Request.UpdateOnIcon is not null ? Request.UpdateOnIcon.Value : false))
                PageStructure.IconUrl = await _FileService.SaveFileAsync(Request.Icon!, SystemFileType.Icons);
            else
                PageStructure.IconUrl = Icon;

            List<PageCard> UpdatedPageCardEntities = new List<PageCard>();
            List<PageCard> NewPageCardEntities = new List<PageCard>();

            List<PageCard> PageCardEntities = await _PageCardRepository
                .Where(x => Request.DarkCardRequest.Select(y => y.Id).Contains(x.Id) ||
                    Request.ParagraphCardRequest.Select(y => y.Id).Contains(x.Id) ||
                    Request.GoalCardRequest.Select(y => y.Id).Contains(x.Id) ||
                    Request.ImageCardRequest.Select(y => y.Id).Contains(x.Id) ||
                    Request.TextCardRequest.Select(y => y.Id).Contains(x.Id))
                .ToListAsync();

            // Dark Cards..
            List<PageCard> UpdatedDarkCardEntities = PageCardEntities
                .Where(x => x.CardType == CardType.DarkCard)
                .ToList();

            _Mapper.Map(Request.DarkCardRequest.Where(x => x.Id != 0), UpdatedDarkCardEntities, typeof(UpdateDarkCardCommand), typeof(PageCard));

            UpdatedPageCardEntities.AddRange(UpdatedDarkCardEntities);

            IEnumerable<PageCard> NewDarkCardEntities = Request.DarkCardRequest
                .Where(x => x.Id == 0)
                .Select(x => new PageCard()
                {
                    orderId = x.orderId,
                    EnglishTitle = x.EnglishTitle,
                    ArabicTitle = x.ArabicTitle,
                    EnglishContent = x.EnglishContent,
                    ArabicContent = x.ArabicContent,
                    IsHide = x.IsHide,
                    CardType = CardType.DarkCard,
                    PageId = Request.Id
                });

            NewPageCardEntities.AddRange(NewDarkCardEntities);

            // Paragraph Cards..
            List<PageCard> NewUpdatedParagraphCardEntities = new List<PageCard>();

            List<PageCard> UpdatedParagraphCardEntities = PageCardEntities
                .Where(x => x.CardType == CardType.ParagraphCard)
                .ToList();

            foreach (UpdateParagraphCardCommand ParagraphCardRequest in Request.ParagraphCardRequest)
            {
                if (ParagraphCardRequest.Id != 0)
                {
                    PageCard? UpdatedParagraphCardEntity = UpdatedParagraphCardEntities
                        .FirstOrDefault(x => x.Id == ParagraphCardRequest.Id);

                    if (UpdatedParagraphCardEntity is not null)
                    {
                        _Mapper.Map(ParagraphCardRequest, UpdatedParagraphCardEntity, typeof(UpdateParagraphCardCommand), typeof(PageCard));

                        NewUpdatedParagraphCardEntities.Add(UpdatedParagraphCardEntity);

                        if (ParagraphCardRequest.Image is not null &&
                            (ParagraphCardRequest.UpdateonImage is not null ? ParagraphCardRequest.UpdateonImage.Value : false))
                        {
                            UpdatedParagraphCardEntity.ImageUrl = await _FileService
                                .SaveFileAsync(ParagraphCardRequest.Image!, SystemFileType.Images);
                        }
                        else if (ParagraphCardRequest.Image is null &&
                            (ParagraphCardRequest.UpdateonImage is not null ? ParagraphCardRequest.UpdateonImage.Value : false))
                        {
                            if (File.Exists(UpdatedParagraphCardEntity.ImageUrl))
                                File.Delete(UpdatedParagraphCardEntity.ImageUrl);

                            UpdatedParagraphCardEntity.ImageUrl = null;
                        }
                    }
                }
            }

            UpdatedPageCardEntities.AddRange(NewUpdatedParagraphCardEntities);

            foreach (UpdateParagraphCardCommand ParagraphCardRequest in Request.ParagraphCardRequest.Where(x => x.Id == 0))
            {
                NewPageCardEntities.Add(new PageCard()
                {
                    orderId = ParagraphCardRequest.orderId,
                    EnglishTitle = ParagraphCardRequest.EnglishTitle,
                    ArabicTitle = ParagraphCardRequest.ArabicTitle,
                    EnglishContent = ParagraphCardRequest.EnglishContent,
                    ArabicContent = ParagraphCardRequest.ArabicContent,
                    IsHide = ParagraphCardRequest.IsHide,
                    CardType = CardType.ParagraphCard,
                    PageId = Request.Id,
                    ImageUrl = ParagraphCardRequest.Image != null
                        ? await _FileService.SaveFileAsync(ParagraphCardRequest.Image!, SystemFileType.Images)
                        : null,
                    ImageInStart = ParagraphCardRequest.ImageInStart
                });
            }

            // Text Cards..
            List<PageCard> UpdatedTextCardEntities = PageCardEntities
                .Where(x => x.CardType == CardType.TextCard)
                .ToList();

            _Mapper.Map(Request.TextCardRequest.Where(x => x.Id != 0), UpdatedTextCardEntities, typeof(UpdateTextCardCommand), typeof(PageCard));

            UpdatedPageCardEntities.AddRange(UpdatedTextCardEntities);

            IEnumerable<PageCard> NewTextCardEntities = Request.TextCardRequest
                .Where(x => x.Id == 0)
                .Select(x => new PageCard()
                {
                    orderId = x.orderId,
                    IsHide = x.IsHide,
                    CardType = CardType.TextCard,
                    PageId = Request.Id,
                    EnglishContent = x.EnglishContent,
                    ArabicContent = x.ArabicContent
                });

            NewPageCardEntities.AddRange(NewTextCardEntities);

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
                    // Image Cards..
                    List<ImageCard> UpdatedImageCardEntities = await _ImageCardRepository
                        .Where(x => Request.ImageCardRequest.Select(y => y.Id).Contains(x.Id))
                        .ToListAsync();

                    _Mapper.Map(Request.ImageCardRequest.Where(x => x.Id != 0), UpdatedImageCardEntities, typeof(UpdateImageCardCommand), typeof(ImageCard));

                    // Images in Image Cards..
                    foreach (UpdateImageCardCommand ImageCardRequest in Request.ImageCardRequest)
                    {
                        int ImageCardId = 0;

                        if (ImageCardRequest.Id == 0)
                        {
                            ImageCard NewImageCardEntity = new ImageCard()
                            {
                                orderId = ImageCardRequest.orderId,
                                IsHide = ImageCardRequest.IsHide,
                                PageId = Request.Id
                            };

                            await _ImageCardRepository.AddAsync(NewImageCardEntity);

                            ImageCardId = NewImageCardEntity.Id;
                        }
                        else
                            ImageCardId = ImageCardRequest.Id;

                        foreach (IFormFile NewCardImage in ImageCardRequest.CardImages)
                        {
                            PageStructureImages NewPageStructureImagesEntity = new PageStructureImages()
                            {
                                ImageUrl = await _FileService.SaveFileAsync(NewCardImage, SystemFileType.Images),
                                ImageCardId = ImageCardId
                            };

                            await _PageStructureImagesRepository.AddAsync(NewPageStructureImagesEntity);
                        }

                        if (ImageCardRequest.DeletedCardImages.Any())
                        {
                            List<PageStructureImages> PageStructureImagesEntitiesToDelete = await _PageStructureImagesRepository
                                .Where(x => ImageCardRequest.DeletedCardImages.Contains(x.Id))
                                .ToListAsync();

                            foreach (PageStructureImages PageStructureImagesEntityToDelete in PageStructureImagesEntitiesToDelete)
                            {
                                if (File.Exists(PageStructureImagesEntityToDelete.ImageUrl))
                                    File.Delete(PageStructureImagesEntityToDelete.ImageUrl);
                            }

                            await _PageStructureImagesRepository.DeleteListAsync(PageStructureImagesEntitiesToDelete);
                        }
                    }

                    // Goal Cards..
                    List<PageCard> UpdatedGoalCardEntities = PageCardEntities
                        .Where(x => x.CardType == CardType.GoalCard)
                        .ToList();

                    List<UpdateGoalCardCommand> UpdateGoalCardCommand1 = Request.GoalCardRequest
                        .Where(x => x.Id != 0 && x.ParentId == null)
                        .ToList();

                    List<PageCard> PageCard1 = UpdatedGoalCardEntities
                        .Where(x => x.ParentId == null)
                        .ToList();

                    _Mapper.Map(UpdateGoalCardCommand1, PageCard1, typeof(UpdateGoalCardCommand), typeof(PageCard));

                    List<UpdateGoalCardCommand> UpdateGoalCardCommand2 = Request.GoalCardRequest
                        .SelectMany(x => x.SubGoals.Where(y => y.Id != 0))
                        .ToList();

                    List<int> SubGoalsIds = Request.GoalCardRequest
                        .SelectMany(x => x.SubGoals)
                        .Select(y => y.Id)
                        .ToList();

                    List<PageCard> PageCard2 = await _PageCardRepository
                        .Where(x => x.ParentId != null &&
                            SubGoalsIds.Contains(x.Id))
                        .ToListAsync();

                    foreach (UpdateGoalCardCommand UpdateGoalCardCommand2s in UpdateGoalCardCommand2)
                    {
                        PageCard? PageCard2s = PageCard2.FirstOrDefault(x => x.Id == UpdateGoalCardCommand2s.Id);

                        if (PageCard2s is not null)
                            UpdateGoalCardCommand2s.ParentId = PageCard2.FirstOrDefault(x => x.Id == UpdateGoalCardCommand2s.Id)!.ParentId;
                    }

                    _Mapper.Map(UpdateGoalCardCommand2, PageCard2, typeof(UpdateGoalCardCommand), typeof(PageCard));

                    UpdatedPageCardEntities.AddRange(PageCard1);
                    UpdatedPageCardEntities.AddRange(PageCard2);

                    foreach (UpdateGoalCardCommand GoalCardRequest in Request.GoalCardRequest)
                    {
                        if (GoalCardRequest.Id == 0)
                        {
                            PageCard NewPageCard = new PageCard()
                            {
                                orderId = GoalCardRequest.orderId,
                                EnglishTitle = GoalCardRequest.EnglishTitle,
                                ArabicTitle = GoalCardRequest.ArabicTitle,
                                IsHide = GoalCardRequest.IsHide,
                                CardType = CardType.GoalCard,
                                PageId = Request.Id
                            };

                            await _PageCardRepository.AddAsync(NewPageCard);

                            NewPageCardEntities.AddRange(GoalCardRequest
                                .SubGoals
                                .Select(x => new PageCard()
                                {
                                    orderId = x.orderId,
                                    EnglishContent = x.EnglishContent,
                                    ArabicContent = x.ArabicContent,
                                    IsHide = x.IsHide,
                                    CardType = CardType.GoalCard,
                                    PageId = Request.Id,
                                    ParentId = NewPageCard.Id
                                }));
                        }
                        else
                        {
                            NewPageCardEntities.AddRange(GoalCardRequest
                                .SubGoals
                                .Where(x => x.Id == 0)
                                .Select(x => new PageCard()
                                {
                                    orderId = x.orderId,
                                    EnglishContent = x.EnglishContent,
                                    ArabicContent = x.ArabicContent,
                                    IsHide = x.IsHide,
                                    CardType = CardType.GoalCard,
                                    PageId = Request.Id,
                                    ParentId = GoalCardRequest.Id
                                }));
                        }
                    }

                    await _PageStructureRepository.UpdateAsync(PageStructure);

                    // All Page Card Entities..
                    await _PageCardRepository.AddRangeAsync(NewPageCardEntities);
                    await _PageCardRepository.UpdateListAsync(UpdatedPageCardEntities);

                    await _ImageCardRepository.UpdateListAsync(UpdatedImageCardEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Updated successfully"
                        : "تم تعديل الصفحة بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
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
