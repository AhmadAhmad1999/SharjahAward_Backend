﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById;
using SharijhaAward.Application.Features.Categories.Queries.GetCategoryById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryCommitteeModel;
using SharijhaAward.Domain.Entities.ComitteeArbitratorModel;
using SharijhaAward.Domain.Entities.CommitteeModel;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetCommitteeById
{
    public class GetCommitteeByIdHandler : IRequestHandler<GetCommitteeByIdQuery, BaseResponse<GetCommitteeByIdDto>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Committee> _CommitteeRepository;
        private readonly IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository;
        private readonly IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository;
        private readonly IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository;
        public GetCommitteeByIdHandler(IMapper _Mapper,
            IAsyncRepository<Committee> _CommitteeRepository,
            IAsyncRepository<ComitteeArbitrator> _ComitteeArbitratorRepository,
            IAsyncRepository<CategoryCommittee> _CategoryCommitteeRepository,
            IAsyncRepository<ComitteeOfficer> _ComitteeOfficerRepository)
        {
            this._Mapper = _Mapper;
            this._CommitteeRepository = _CommitteeRepository;
            this._ComitteeArbitratorRepository = _ComitteeArbitratorRepository;
            this._CategoryCommitteeRepository = _CategoryCommitteeRepository;
            this._ComitteeOfficerRepository = _ComitteeOfficerRepository;
        }

        public async Task<BaseResponse<GetCommitteeByIdDto>> Handle(GetCommitteeByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Committee? CommitteeEntity = await _CommitteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CommitteeEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Committee is not Found"
                    : "اللجنة غير موجودة";

                return new BaseResponse<GetCommitteeByIdDto>(ResponseMessage, false, 404);
            }

            List<ArbitratorDto> Arbitrators = _Mapper.Map<List<ArbitratorDto>>(await _ComitteeArbitratorRepository
                .Where(x => x.CommitteeId == Request.Id)
                .Select(x => x.Arbitrator!)
                .ToListAsync());

            List<CategoryDto> Categories = _Mapper.Map<List<CategoryDto>>(await _CategoryCommitteeRepository
                .Where(x => x.CommitteeId == Request.Id)
                .Select(x => x.Category!)
                .ToListAsync());

            List<ArbitratorDto> Officers = _Mapper.Map<List<ArbitratorDto>>(await _ComitteeOfficerRepository
                .Where(x => x.CommitteeId == Request.Id)
                .Select(x => x.Arbitrator!)
                .ToListAsync());

            GetCommitteeByIdDto CommitteeDto = _Mapper.Map<GetCommitteeByIdDto>(CommitteeEntity);

            CommitteeDto.Arbitrators = Arbitrators;
            CommitteeDto.Officers = Officers;
            CommitteeDto.Categories = Categories;
            CommitteeDto.ChairmanName = Request.lang == "en"
                ? CommitteeEntity.EnglishName
                : CommitteeEntity.ArabicName;

            return new BaseResponse<GetCommitteeByIdDto>(ResponseMessage, true, 200, CommitteeDto);
        }
    }
}
