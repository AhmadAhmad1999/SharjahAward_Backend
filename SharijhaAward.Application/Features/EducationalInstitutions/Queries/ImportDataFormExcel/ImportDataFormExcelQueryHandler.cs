using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.ImportDataFormExcel
{
    public class ImportDataFormExcelQueryHandler
        : IRequestHandler<ImportDataFormExcelQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IExcelHelper<EducationalInstitution> _excelHelper;
        private readonly IFileService _fileService;

        public ImportDataFormExcelQueryHandler(IFileService fileService, IAsyncRepository<EducationalInstitution> educationalInstitutionRepository, IExcelHelper<EducationalInstitution> excelHelper)
        {
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _excelHelper = excelHelper;
            _fileService = fileService;
        }

        public async Task<BaseResponse<object>> Handle(ImportDataFormExcelQuery request, CancellationToken cancellationToken)
        {
            var filePath = await _fileService.SaveFileAsync(request.ImporterFile);
            byte[] file = await _fileService.ReadFileAsync(filePath);
            var EducationalInstitutions = _excelHelper.ImportFromExcel(file);

            if(request.Replace)
            {
                var EduInstitutions = await _educationalInstitutionRepository.ListAllAsync();
                await _educationalInstitutionRepository.DeleteListAsync(EduInstitutions);
                await _educationalInstitutionRepository.AddRangeAsync(EducationalInstitutions);
            }
            else
            {
                await _educationalInstitutionRepository.AddRangeAsync(EducationalInstitutions);
            }

            return new BaseResponse<object>("", true, 200);
        }
    }
}
