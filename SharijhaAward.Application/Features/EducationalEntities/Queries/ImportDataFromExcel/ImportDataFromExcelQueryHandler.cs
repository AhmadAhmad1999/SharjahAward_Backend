using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
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
        : IRequestHandler<ImportDataFromExcelQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalEntity> _educationalEntityRepository;
        private readonly IExcelHelper<EducationalEntity> _excelHelper;
        private readonly IFileService _fileService;

        public ImportDataFromExcelQueryHandler(IAsyncRepository<EducationalEntity> educationalEntityRepository, IExcelHelper<EducationalEntity> excelHelper, IFileService fileService)
        {
            _educationalEntityRepository = educationalEntityRepository;
            _excelHelper = excelHelper;
            _fileService = fileService;
        }

        public async Task<BaseResponse<object>> Handle(ImportDataFromExcelQuery request, CancellationToken cancellationToken)
        {
            var filePath = await _fileService.SaveFileAsync(request.ImporterFile, SystemFileType.ExcelFiles);
            byte[] file = await _fileService.ReadFileAsync(filePath);
            var EducationalInstitutions = _excelHelper.ImportFromExcel(file);

            if (request.Replace)
            {
                var EduInstitutions = await _educationalEntityRepository.ListAllAsync();
                await _educationalEntityRepository.DeleteListAsync(EduInstitutions);
                await _educationalEntityRepository.AddRangeAsync(EducationalInstitutions);
            }
            else
            {
                await _educationalEntityRepository.AddRangeAsync(EducationalInstitutions);
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}
