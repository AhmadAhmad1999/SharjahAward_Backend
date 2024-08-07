using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.EducationalEntities.Queries.GetExcelFilePrototype;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.ImportDataFromExcel
{
    public class ImportDataFromExcelQueryHandler
        : IRequestHandler<ImportDataFromExcelQuery, BaseResponse<List<int>>>
    {
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IExcelHelper<EducationalEntityExcelDto> _excelHelper;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
         
        public ImportDataFromExcelQueryHandler(IMapper mapper, IAsyncRepository<EducationalEntity> educationalEntityRepository, IExcelHelper<EducationalEntityExcelDto> excelHelper, IFileService fileService)
        {
            _educationalEntityRepository = educationalEntityRepository;
            _excelHelper = excelHelper;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<int>>> Handle(ImportDataFromExcelQuery request, CancellationToken cancellationToken)
        {
            var filePath = await _fileService.SaveFileAsync(request.ImporterFile, SystemFileType.ExcelFiles);
            byte[] file = await _fileService.ReadFileAsync(filePath, SystemFileType.ExcelFiles);
            var EducationalEntities = _excelHelper.ImportFromExcel(file);

            var data = _mapper.Map<List<EducationalEntity>>(EducationalEntities);
            List<int> problematicRows = new List<int>();

            for(int i=0; i<EducationalEntities.Count(); i++)
            {
                if (string.IsNullOrEmpty(EducationalEntities[i].EnglishName) || string.IsNullOrEmpty(EducationalEntities[i].ArabicName) )
                {
                    problematicRows.Add(i++);
                }
            }

            if (problematicRows.Count() > 0)
            {
                return new BaseResponse<List<int>>("", false, 403, problematicRows);
            }

            if (request.Replace)
            {
                var EduInstitutions = await _educationalEntityRepository.ListAllAsync();
                await _educationalEntityRepository.DeleteListAsync(EduInstitutions);
                await _educationalEntityRepository.AddRangeAsync(data);
            }
            else
            {
                await _educationalEntityRepository.AddRangeAsync(data);
            }

            return new BaseResponse<List<int>>("", true, 200, problematicRows);
        }
    }
}
