﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.InstructionModel;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions
{
    public class GetAllInstructionsHandler : IRequestHandler<GetAllInstructionsQuery, BaseResponse<List<GetAllInstructionsListVM>>>
    {
        private readonly IAsyncRepository<Instruction> _InstructionRepository;
        private readonly IMapper _Mapper;
        public GetAllInstructionsHandler(IAsyncRepository<Instruction> InstructionRepository,
            IMapper Mapper)
        {
            _InstructionRepository = InstructionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllInstructionsListVM>>> Handle(GetAllInstructionsQuery Request, 
            CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<GetAllInstructionsListVM> Instructions = _Mapper.Map<List<GetAllInstructionsListVM>>(await _InstructionRepository
                .OrderByDescending(filterObject ,x => x.CreatedAt, Request.page, Request.perPage)
                .ToListAsync());

            int TotalCount = await _InstructionRepository.WhereThenFilter(i => true, filterObject).CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllInstructionsListVM>>(ResponseMessage, true, 200, Instructions, PaginationParameter);
        }
    }
}
