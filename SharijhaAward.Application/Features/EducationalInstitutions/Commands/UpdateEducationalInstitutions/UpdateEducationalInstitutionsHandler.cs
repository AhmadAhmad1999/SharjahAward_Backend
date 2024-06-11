using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions
{
    public class UpdateEducationalInstitutionsHandler 
        : IRequestHandler<UpdateEducationalInstitutionsMainCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        public UpdateEducationalInstitutionsHandler(IMapper Mapper,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository)
        {
            _Mapper = Mapper;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
        }
        public async Task<BaseResponse<object>> Handle(UpdateEducationalInstitutionsMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<EducationalInstitution>? EducationalInstitutionEntitiesToUpdate = await _EducationalInstitutionRepository
                .Where(x => Request.UpdateEducationalInstitutionsCommand.Select(y => y.Id).Contains(x.Id))
                .ToListAsync();

            foreach (EducationalInstitution EducationalInstitutionEntityToUpdate in EducationalInstitutionEntitiesToUpdate)
            {
                UpdateEducationalInstitutionsCommand NewRequestData = Request.UpdateEducationalInstitutionsCommand
                    .FirstOrDefault(x => x.Id == EducationalInstitutionEntityToUpdate.Id)!;

                _Mapper.Map(NewRequestData, EducationalInstitutionEntityToUpdate, typeof(UpdateEducationalInstitutionsCommand), typeof(EducationalInstitution));
            }

            await _EducationalInstitutionRepository.UpdateListAsync(EducationalInstitutionEntitiesToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Educational institutions has been updated successfully"
                : "تم تعديل المؤسسات التعليمية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}