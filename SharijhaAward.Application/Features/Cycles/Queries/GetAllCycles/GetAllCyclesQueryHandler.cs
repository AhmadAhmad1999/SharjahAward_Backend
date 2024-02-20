using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.GetAllNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetAllCycles
{
    public class GetAllCyclesQueryHandler
        : IRequestHandler<GetAllCyclesQuery, BaseResponse<List<CycleListVM>>>
    {
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetAllCyclesQueryHandler(IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<CycleListVM>>> Handle(GetAllCyclesQuery request, CancellationToken cancellationToken)
        {
            var CycleList = request.pageSize == -1 || request.page == 0
               ? await _cycleRepository.ListAllAsync()
               : await _cycleRepository.GetPagedReponseAsync(request.page, request.pageSize);
            string msg;

            if (CycleList.Count == 0)
            {
                msg = request.lang == "en"
                   ? "There is No Cycles"
                   : "لا يوجد دورات";

                return new BaseResponse<List<CycleListVM>>(msg, false, 404);
            }
            List<CycleListVM> cycleListVM = new List<CycleListVM>(); 

            for(int i= 0; i < CycleList.Count; i++)
            {
                CycleListVM cycle = new CycleListVM();

                cycle.id = CycleList[i].Id;
                cycle.ArabicName = CycleList[i].ArabicName;
                cycle.EnglishName = CycleList[i].EnglishName;
                cycle.Year = CycleList[i].Year; ;
                cycle.Status = CycleList[i].Status;
                cycle.RegistrationPortalClosingDate = CycleList[i].RegistrationPortalClosingDate;
                cycle.RegistrationPortalOpeningDate = CycleList[i].RegistrationPortalOpeningDate;
                cycle.IndividualCategoryNumber = CycleList[i].IndividualCategoryNumber;
                cycle.GroupCategoryNumber = CycleList[i].GroupCategoryNumber;
                cycle.Name = request.lang == "en"
                    ? CycleList[i].EnglishName
                    : CycleList[i].ArabicName;

                cycleListVM.Add(cycle);
            }
            var Data = _mapper.Map<List<CycleListVM>>(cycleListVM);

            msg = request.lang == "en"
                ? "The News Retrieved Success"
                : "تم إسترجاع الاأخبار بنجاح";


            return new BaseResponse<List<CycleListVM>>(msg, false, 200, Data);
        }
    }
}
