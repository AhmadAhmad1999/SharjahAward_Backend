﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
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

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllSpecialConditionsByCategoryId
{
    public class GetAllSpecialConditionsByCategoryIdQueryHandler
        : IRequestHandler<GetAllSpecialConditionsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllSpecialConditionsByCategoryIdQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
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
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<TermAndConditionListVM>>> Handle(GetAllSpecialConditionsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.CategoryId);
            string msg;
            if (category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<TermAndConditionListVM>>(msg, false, 404);
            }
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var user = await _userRepository.GetByIdAsync(int.Parse(UserId));
            var form = await _providedFormRepository.FirstOrDefaultAsync(p => p.Id == request.formId);

            var Terms = await _termRepository
                .Where(t => t.CategoryId == category.Id)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            List<ConditionsProvidedForms> conditionsProvideds = await _conditionsProvidedFormsRepository
                .Where(x => Terms.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.ProvidedFormId == form!.Id)
                .ToListAsync();

            for (int i = 0; i < Terms.Count(); i++)
            {
                var conditionsProvidedsobject =
                     conditionsProvideds.FirstOrDefault(
                         c => c.ProvidedFormId == form!.Id && c.TermAndConditionId == Terms[i].Id);

                if(conditionsProvidedsobject == null)
                {
                    var conditionsProvided = new ConditionsProvidedForms()
                    {
                        ProvidedFormId = form!.Id,
                        TermAndConditionId = Terms[i].Id,
                        IsAgree = false
                    };

                    await _conditionsProvidedFormsRepository.AddAsync(conditionsProvided);
                    conditionsProvideds.Add(conditionsProvided);
                }
            }

            var data = _mapper.Map<List<TermAndConditionListVM>>(Terms);

            List<ConditionAttachment> AllConditionAttachmentEntities = await _conditionAttachmentRepository
                .Where(x => conditionsProvideds.Select(y => y.Id).Any(y => y == x.ConditionsProvidedFormsId))
                .ToListAsync();

            for (int i = 0; i < data.Count; i++)
            {
                var xx = conditionsProvideds
                    .FirstOrDefault(x => x.TermAndConditionId == data[i].Id);

                data[i].ConditionsAttachments = _mapper.Map<ConditionProvidedFormListVm>(xx);

                if (data[i].NeedAttachment)
                {
                    data[i].ConditionsAttachments!.Attachments = _mapper.Map<List<AttachmentListVM>>(AllConditionAttachmentEntities
                        .Where(x => x.ConditionsProvidedFormsId == xx.Id)
                        .ToList());

                    if (data[i].ConditionsAttachments!.Attachments.Any(a => a.IsAccept == false))
                        data[i].Rejected = true;
                }

                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            data = data.OrderByDescending(a => a.CreateAt).ToList();

            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data);
        }
    }
}
