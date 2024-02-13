using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.TrainingWorkshopModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TrainingWorkshops.Queries.GetAllTrainingWorkshops
{
    public class GetAllTrainingWorkshopQueryHandler
        : IRequestHandler<GetAllTrainingWorkshopsQuery, List<TrainingWorkshopListVm>>
    {
        private readonly IAsyncRepository<TrainingWorkshop> _trainingWorkshopRepository;
        private readonly IMapper _mapper;

        public GetAllTrainingWorkshopQueryHandler(IAsyncRepository<TrainingWorkshop> trainingWorkshopRepository, IMapper mapper)
        {
            _trainingWorkshopRepository = trainingWorkshopRepository;
            _mapper = mapper;
        }

        public async Task<List<TrainingWorkshopListVm>> Handle(GetAllTrainingWorkshopsQuery request, CancellationToken cancellationToken)
        {
            var workShops = await _trainingWorkshopRepository.ListAllAsync();
            if (workShops.Count == 0)
            {
                throw new OpenQA.Selenium.NotFoundException("Training Workshop is Empty");
            }
            List<TrainingWorkshopListVm> trainingWorkshops = new List<TrainingWorkshopListVm>();
            for(int i = 0 ; i < workShops.Count ; i++)
            {
                TrainingWorkshopListVm listVm = new TrainingWorkshopListVm()
                {
                    Id = workShops[i].Id,
                    ArabicTitle = workShops[i].ArabicTitle,
                    EnglishTitle = workShops[i].EnglishTitle,
                    ArabicWorkshopAttachment = workShops[i].ArabicWorkshopAttachment,
                    EnglishWorkshopAttachment = workShops[i].EnglishWorkshopAttachment,
                    Thumbnail = workShops[i].Thumbnail,

                    Title = request.lang=="ar"?
                    workShops[i].ArabicTitle :
                    workShops[i].EnglishTitle,

                    WorkshopAttachment = request.lang=="ar"?
                    workShops[i].ArabicWorkshopAttachment : 
                    workShops[i].EnglishWorkshopAttachment
                };
                trainingWorkshops.Add(listVm);
            }
            return _mapper.Map<List<TrainingWorkshopListVm>>(trainingWorkshops);
        }
    }
}
