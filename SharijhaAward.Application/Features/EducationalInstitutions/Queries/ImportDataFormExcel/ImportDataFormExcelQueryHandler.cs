using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetExcelFilePrototype;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.ImportDataFormExcel
{
    public class ImportDataFormExcelQueryHandler
        : IRequestHandler<ImportDataFormExcelQuery, BaseResponse<List<int>>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IExcelHelper<EducationalInstitutionExcelDto> _excelHelper;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public ImportDataFormExcelQueryHandler(IMapper mapper, IFileService fileService, IAsyncRepository<EducationalInstitution> educationalInstitutionRepository, IExcelHelper<EducationalInstitutionExcelDto> excelHelper)
        {
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _excelHelper = excelHelper;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<int>>> Handle(ImportDataFormExcelQuery request, CancellationToken cancellationToken)
        {
            var filePath = await _fileService.SaveFileAsync(request.ImporterFile, SystemFileType.ExcelFiles);
            byte[] file = await _fileService.ReadFileAsync(filePath, SystemFileType.ExcelFiles);
            var EducationalInstitutions = _excelHelper.ImportFromExcel(file);

            var data = _mapper.Map<List<EducationalInstitution>>(EducationalInstitutions);

            List<int> problematicRows = new List<int>();

            for (int i = 0; i < EducationalInstitutions.Count(); i++)
            {
                if (string.IsNullOrEmpty(EducationalInstitutions[i].EnglishName) || string.IsNullOrEmpty(EducationalInstitutions[i].ArabicName))
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
                var EduInstitutions = await _educationalInstitutionRepository.ListAllAsync();
                await _educationalInstitutionRepository.DeleteListAsync(EduInstitutions);
                await _educationalInstitutionRepository.AddRangeAsync(data);
            }
            else
            {
                await _educationalInstitutionRepository.AddRangeAsync(data);
            }

            return new BaseResponse<List<int>>("", true, 200, problematicRows);
        }
    }
}
