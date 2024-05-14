using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.ExportToExcel
{
    public class NewsExportToExcelQueryHandler
         : IRequestHandler<NewsExportToExcelQuery, BaseResponse<byte[]>>
    {
        private readonly IAsyncRepository<Domain.Entities.NewsModel.News> _newsRepository;
        private readonly IExcelHelper<NewsExportDto> _excelHelper;
        private readonly IMapper _mapper;

        public NewsExportToExcelQueryHandler(IAsyncRepository<Domain.Entities.NewsModel.News> newsRepository, IExcelHelper<NewsExportDto> excelHelper, IMapper mapper)
        {
            _newsRepository = newsRepository;
            _excelHelper = excelHelper;
            _mapper = mapper;
        }

        public async Task<BaseResponse<byte[]>> Handle(NewsExportToExcelQuery request, CancellationToken cancellationToken)
        {
            var news = await _newsRepository.ListAllAsync();

            var data = _mapper.Map<List<NewsExportDto>>(news);

            var file = _excelHelper.ExportToExcel(data);

            return new BaseResponse<byte[]>("", true, 200, file);
        }
    }
}
