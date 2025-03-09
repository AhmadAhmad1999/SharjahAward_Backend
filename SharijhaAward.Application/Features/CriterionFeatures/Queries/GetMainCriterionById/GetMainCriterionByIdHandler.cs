using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetMainCriterionById
{
    public class GetMainCriterionByIdHandler : IRequestHandler<GetMainCriterionByIdQuery, BaseResponse<GetMainCriterionByIdDto>>
    {
        private readonly IAsyncRepository<Criterion> _CriterionRepository;
        private readonly IAsyncRepository<CriterionItem> _CriterionItemRepository;
        private readonly IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository;
        private readonly IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository;
        private readonly IMapper _Mapper;

        public GetMainCriterionByIdHandler(IAsyncRepository<Criterion> _CriterionRepository,
            IAsyncRepository<CriterionItem> _CriterionItemRepository,
            IAsyncRepository<CriterionAttachmentType> _CriterionAttachmentTypeRepository,
            IAsyncRepository<CriterionItemAttachmentType> _CriterionItemAttachmentTypeRepository,
            IMapper _Mapper)
        {
            this._CriterionRepository = _CriterionRepository;
            this._CriterionItemRepository = _CriterionItemRepository;
            this._CriterionAttachmentTypeRepository = _CriterionAttachmentTypeRepository;
            this._CriterionItemAttachmentTypeRepository = _CriterionItemAttachmentTypeRepository;
            this._Mapper = _Mapper;
        }
        public async Task<BaseResponse<GetMainCriterionByIdDto>> Handle(GetMainCriterionByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Criterion? CriterionEntity = await _CriterionRepository
                .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.Id);

            if (CriterionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Main criterion is not found"
                    : "المعيار الرئيسي غير موجود";

                return new BaseResponse<GetMainCriterionByIdDto>(ResponseMessage, false, 404);
            }

            GetMainCriterionByIdDto GetMainCriterionByIdDto = _Mapper.Map<GetMainCriterionByIdDto>(CriterionEntity);

            List<Criterion> CriterionEntities = await _CriterionRepository
                .Where(x => x.ParentId == Request.Id)
                .ToListAsync();

            List<CriterionAttachmentType> CriterionAttachmentTypeEntities = _CriterionAttachmentTypeRepository
                .Where(x => CriterionEntities.Select(y => y.Id).Contains(x.CriterionId) &&
                    x.AttachmentType != null)
                .ToList();

            List<CriterionItem> CriterionItemEntities = await _CriterionItemRepository
                .Where(x => CriterionEntities.Select(y => y.Id).Contains(x.CriterionId))
                .ToListAsync();

            List<CriterionItemAttachmentType> CriterionItemAttachmentTypeEntities = _CriterionItemAttachmentTypeRepository
                .Where(x => CriterionItemEntities.Select(y => y.Id).Contains(x.CriterionItemId))
                .ToList();

            GetMainCriterionByIdDto.SubCriterions = CriterionEntities
                .Select(x => new SubCriterionListDto()
                {
                    Id = x.Id,
                    ArabicTitle = x.ArabicTitle,
                    AttachFilesOnSubCriterion = x.AttachFilesOnSubCriterion != null
                        ? x.AttachFilesOnSubCriterion.Value
                        : false,
                    EnglishTitle = x.EnglishTitle,
                    MaxAttachmentNumber = x.MaxAttachmentNumber,
                    Score = x.Score,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB,
                    AttachmentType = CriterionAttachmentTypeEntities
                        .Where(y => y.CriterionId == x.Id)
                        .Select(y => y.AttachmentType!.Value)
                        .ToList(),
                    CriterionItems = CriterionItemEntities
                        .Where(y => y.CriterionId == x.Id)
                        .Select(y => new CriterionItemListDto()
                        {
                            Id = y.Id,
                            ArabicName = y.ArabicName,
                            EnglishName = y.EnglishName,
                            MaxAttachmentNumber = y.MaxAttachmentNumber,
                            Score = y.Score,
                            SizeOfAttachmentInKB= y.SizeOfAttachmentInKB,
                            AttachmentType = CriterionItemAttachmentTypeEntities
                                .Where(z => z.CriterionItemId == y.Id)
                                .Select(z => z.AttachmentType)
                                .ToList()
                        }).ToList()
                }).ToList();

            return new BaseResponse<GetMainCriterionByIdDto>(ResponseMessage, true, 200, GetMainCriterionByIdDto);
        }
    }
}
