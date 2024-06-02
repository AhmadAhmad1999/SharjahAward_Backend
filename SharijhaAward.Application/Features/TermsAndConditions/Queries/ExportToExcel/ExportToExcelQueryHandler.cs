﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Queries.ExportToExcel;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.ExportToExcel
{
    public class ExportToExcelQueryHandler
        : IRequestHandler<ExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IExcelHelper<TermExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public ExportToExcelQueryHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository, IExcelHelper<TermExportDto> excelHelper, IMapper mapper)
        {
            _termAndConditionRepository = termAndConditionRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(ExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var terms = await _termAndConditionRepository.ListAllAsync();

            var data = _mapper.Map<List<TermExportDto>>(terms);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
            
        }
    }
}
