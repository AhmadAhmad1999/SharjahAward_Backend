using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using SharijhaAward.Domain.Entities.TrainingWrokshopeAttachments;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class GetTrainingWorkshopByIdQueryHandler 
        : IRequestHandler<GetTrainingWorkshopByIdQuery, BaseResponse<TrainingWorkshopDto>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IAsyncRepository<TrainingWrokshopeAttachment> _TrainingWrokshopeAttachmentRepository;
        private readonly IMapper _mapper;

        public GetTrainingWorkshopByIdQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository,
            IAsyncRepository<TrainingWrokshopeAttachment> TrainingWrokshopeAttachmentRepository,
            IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _TrainingWrokshopeAttachmentRepository = TrainingWrokshopeAttachmentRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<TrainingWorkshopDto>> Handle(GetTrainingWorkshopByIdQuery request, CancellationToken cancellationToken)
        {
            var trainingWorkshop = await _trainingWorkshopRepository
                .FirstOrDefaultAsync(t => t.Id == request.Id);

            if (trainingWorkshop == null)
                return new BaseResponse<TrainingWorkshopDto>("not Found", false, 404);

            var data = _mapper.Map<TrainingWorkshopDto>(trainingWorkshop);

            data.Attachments = await _TrainingWrokshopeAttachmentRepository
                .Where(x => x.WorkshopeId == request.Id)
                .Select(x => new WorkshopAttachmentListVM()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName,
                    Name = request.lang == "en"
                        ? x.EnglishName 
                        : x.ArabicName,
                    AttachementURl = x.AttachementPath,
                    AttachmentType = x.AttachmentType,
                    SizeOfAttachmentInKB = x.SizeOfAttachmentInKB
                }).ToListAsync();

            
            data.Title = request.lang == "ar" ? trainingWorkshop.ArabicTitle : trainingWorkshop.EnglishTitle;

            return new BaseResponse<TrainingWorkshopDto>("", true, 200, data);
        }
    }
}
