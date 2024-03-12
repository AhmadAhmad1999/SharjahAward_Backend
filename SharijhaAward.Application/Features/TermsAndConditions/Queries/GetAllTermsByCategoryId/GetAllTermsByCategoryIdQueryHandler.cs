using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class GetAllTermsByCategoryIdQueryHandler
        : IRequestHandler<GetAllTermsByCategoryIdQuery, BaseResponse<List<PublicTremsAndConditionsListVm>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllTermsByCategoryIdQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<ConditionAttachment> conditionAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository,
            IUserRepository userRepository,
            IJwtProvider jwtProvider,
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _providedFormRepository = providedFormRepository;
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _termRepository = termRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<PublicTremsAndConditionsListVm>>> Handle(GetAllTermsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            string msg;
            if(category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";
                return new BaseResponse<List<PublicTremsAndConditionsListVm>>(msg, false, 404);
            }
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var user = await _userRepository.GetByIdAsync(new Guid(UserId));
            var form = _providedFormRepository.FirstOrDefault(p => p.userId == user.Id);

            var Terms = _termRepository.WhereThenInclude(t => t.CategoryId==category.Id, t => t.ConditionAttachments ).Where(t=>t.IsSpecial==false).ToList();

           
            List<AttachmentListVM> Attachmets = _mapper.Map<List<AttachmentListVM>>(await _conditionAttachmentRepository
                .Include(x => x.ConditionsProvidedForms).Include(x => x.ConditionsProvidedForms.TermAndCondition)
                .Where(x => x.ConditionsProvidedForms.TermAndCondition.CategoryId == category.Id &&
                    x.ConditionsProvidedForms.TermAndCondition.IsSpecial == false &&
                    x.ConditionsProvidedForms.ProvidedFormId == form!.Id).ToListAsync());
            
            var data = _mapper.Map<List<PublicTremsAndConditionsListVm>>(Terms);
            for (int i = 0; i<data.Count; i++)
            {
                data[i].ConditionAttachments = _mapper.Map<List<ConditionProvidedFormListVm>>(Terms[i].ConditionAttachments);
               
                for (int j = 0; j < data[i].ConditionAttachments!.Count; j++)
                {
                    data[i].ConditionAttachments![j].Attachments = Attachmets;
                }
                
                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            return new BaseResponse<List<PublicTremsAndConditionsListVm>>("", true, 200, data);
        }
    }
}
