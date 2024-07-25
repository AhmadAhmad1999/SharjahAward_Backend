﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class GetAllProvidedFormsQueryHandler
        : IRequestHandler<GetAllProvidedFormsQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        public GetAllProvidedFormsQueryHandler(IAsyncRepository<ExtraAttachment> extraAttachmentRepository,  IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository, IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsProvidedFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IAsyncRepository<Category> categoryRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
            _cycleConditionsProvidedFormRepository = cycleConditionsProvidedFormRepository;
            _extraAttachmentRepository = extraAttachmentRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllProvidedFormsQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            
            if (User == null)
            {
                return new BaseResponse<List<FormListVm>> ("", false, 401);
            }
           
            FilterObject filterObject = new FilterObject() { Filters= request.filters };

            var form = request.Type == null
                ? await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).OrderByDescending(x => x.CreatedAt).ToListAsync()
                : await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).Where(f=>f.Type==request.Type)
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();
           
            

            var data = _mapper.Map<List<FormListVm>> (form);
            
            for (int i = 0; i < data.Count(); i++)
            {

                
                var SubCategory = await _categoryRepository.GetByIdAsync(form[i].categoryId);
                
                if(SubCategory == null)
                {
                    return new BaseResponse<List<FormListVm>>("", false, 400);
                }

                var Category = await _categoryRepository.GetByIdAsync(SubCategory!.ParentId);
                
                if (Category == null)
                {
                    return new BaseResponse<List<FormListVm>>("", false, 400);
                }

                data[i].SubCategoryName = request.lang=="en"
                    ? SubCategory.EnglishName
                    : SubCategory.ArabicName;

                data[i].CategoryName = request.lang == "en"
                    ? Category.EnglishName
                    : Category.ArabicName;


                data[i].RejectedSteps = new List<int>();

                var cycleConditions = await _cycleConditionsProvidedFormRepository
                    .Include(c=>c.CycleCondition)
                    .Include(c => c.Attachments.Where(a => a.IsAccept == false))
                    .Where(c => c.ProvidedFormId == form[i].Id && c.CycleCondition.NeedAttachment == true)
                    .ToListAsync();

                if(cycleConditions.Count() > 0)
                {
                    foreach( var c in cycleConditions)
                    {
                        if(c.Attachments.Count() > 0)
                        {
                            data[i].RejectedSteps!.Add(1);
                        }
                        break;
                    }
                }

                var TermAndConditions = await _conditionsProvidedFormsRepository
                    .Include(c=>c.TermAndCondition)
                    .Include(c => c.Attachments.Where(a => a.IsAccept == false))
                    .Where(c => c.ProvidedFormId == form[i].Id && c.TermAndCondition.NeedAttachment == true)
                    .ToListAsync();

                if (TermAndConditions.Count() > 0)
                {
                    foreach (var t in TermAndConditions)
                    {
                        if (t.Attachments.Count() > 0)
                        {
                            data[i].RejectedSteps!.Add(3);
                        }
                        break;
                    }
                }

                var ExtraAttachments = await _extraAttachmentRepository
                    .Where(e => e.ProvidedFormId == form[i].Id)
                    .Include(e => e.ExtraAttachmentFiles!.Where(a=>a.IsAccept == false))
                    .ToListAsync();

                if (ExtraAttachments.Count() > 0)
                {
                    foreach (var e in ExtraAttachments)
                    {
                        if (e.ExtraAttachmentFiles!.Count() > 0)
                        {
                            data[i].RejectedSteps!.Add(6);
                        }
                        break;
                    }
                }
            }

            return new BaseResponse<List<FormListVm>> ("", true, 200, data);
        }
    }
}
