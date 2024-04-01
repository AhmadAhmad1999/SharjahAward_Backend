using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetWorkShopsByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetTrainingWorkshopById
{
    public class GetTrainingWorkshopByIdQueryHandler 
        : IRequestHandler<GetTrainingWorkshopByIdQuery, BaseResponse<TrainingWorkshopDto>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public GetTrainingWorkshopByIdQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<TrainingWorkshopDto>> Handle(GetTrainingWorkshopByIdQuery request, CancellationToken cancellationToken)
        {
            var trainingWorkshop = await _trainingWorkshopRepository.WhereThenInclude(t => t.Id == request.Id, t => t.Attachments).FirstOrDefaultAsync();
            if (trainingWorkshop == null)
            {
                return new BaseResponse<TrainingWorkshopDto>("not Found", false, 404);
            }
            var data = _mapper.Map<TrainingWorkshopDto>(trainingWorkshop);

            data.Attachments = _mapper.Map<List<WorkshopAttachmentListVM>>(data.Attachments);
            for (int j = 0; j < data.Attachments.Count; j++)
            {
                data.Attachments[j].Name = request.lang == "en"
                    ? data.Attachments[j].EnglishName
                    : data.Attachments[j].ArabicName;
                data.Attachments[j].AttachementURl = trainingWorkshop.Attachments[j].AttachementPath;
            }
            data.Title = request.lang == "ar" ? trainingWorkshop.ArabicTitle : trainingWorkshop.EnglishTitle;


            return new BaseResponse<TrainingWorkshopDto>("", true, 200, data);
        }
    }
}
