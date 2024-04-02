﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.CreateProvidedForm
{
    public class CreateProvidedFormCommandHandler 
        : IRequestHandler<CreateProvidedFormCommand , BaseResponse<int>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _Providedrepository;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionFormsRepository;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<CycleCondition> _cycleConditionRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;       
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _mapper;

        public CreateProvidedFormCommandHandler(
            IJwtProvider JwtProvider,
            IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsProvidedFormRepository,
            IAsyncRepository<CycleCondition> cycleConditionRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionFormsRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedrepository,
            IAsyncRepository<Cycle> cyclerepository,
            IAsyncRepository<Category> categoryrepository,
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository,
            IMapper mapper,
            IAsyncRepository<TermAndCondition> termRepository
            )
        {
            _Providedrepository = providedrepository;
            _CycleRepository = cyclerepository;
            _cycleConditionsProvidedFormRepository = cycleConditionsProvidedFormRepository;
            _cycleConditionRepository = cycleConditionRepository;
            _JwtProvider = JwtProvider;
            _CategoryRepository = categoryrepository;
            _conditionFormsRepository = conditionFormsRepository;
            _userRepository = userRepository;
            _termRepository = termRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateProvidedFormCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                        ? "Provided Form has been Added"
                        : "تم إنشاء إستمارة التسجيل";

            var UserId = _JwtProvider.GetUserIdFromToken(request.token);

            if(UserId == null)
            {
                return new BaseResponse<int>("Invalid Token", false, 400);
            }

            var FormsOfUser = _Providedrepository.Where(p => p.userId == new Guid(UserId)).ToList();
            
            var category =await _CategoryRepository.GetByIdAsync(request.categoryId);
            
            for(int i=0; i < FormsOfUser.Count(); i++)
            {
                if (FormsOfUser[i].categoryId == category.Id)
                {
                    msg = request.lang == "en"
                        ? "You have already subscribed to this category"
                        : "لقد اشتركت بهذه الفئة بالفعل";

                    return new BaseResponse<int>(msg, false, 400);
                }
            }
            var User = await _userRepository.GetByIdAsync(new Guid(UserId));
            var cycle = await _CycleRepository.GetByIdAsync(category.CycleId);

            if (category.CategoryClassification == Domain.Constants.CategoryConstants.CategoryClassification.Individual)
            {
                if(User.NumberOfIndividualCategories >= cycle.IndividualCategoryNumber)
                {
                    msg = request.lang == "en"
                         ? "You cannot subscribe to more Individual Categories"
                         : "لا يمكنك الاشتراك بالمزيد من الفئات الفردية";

                    return new BaseResponse<int>(msg, false, 400);
                }
                User.NumberOfIndividualCategories++;
            }
            else
            {
                if (User.NumberOfGroupCategories >= cycle.GroupCategoryNumber)
                {
                    msg = request.lang == "en"
                        ? "You cannot subscribe to more Group Categories"
                        : "لا يمكنك الاشتراك بالمزيد من الفئات الجماعية";

                    return new BaseResponse<int>(msg, false, 400);
                }
                User.NumberOfGroupCategories++;
            }
            

            var ProvidedForm = _mapper.Map<Domain.Entities.ProvidedFormModel.ProvidedForm>(request);
          
            ProvidedForm.userId = new Guid(UserId);
            ProvidedForm.CycleNumber = cycle.CycleNumber;
            ProvidedForm.CycleYear = cycle.Year;
            ProvidedForm.Type = 0;
            ProvidedForm.Status = 0;
            ProvidedForm.CurrentStep = 1;
            ProvidedForm.TotalStep = 7;
            ProvidedForm.PercentCompletion = 0;

            var data =  await _Providedrepository.AddAsync(ProvidedForm);

            await _userRepository.UpdateAsync(User);

            var terms = _termRepository.Where(t => t.CategoryId == category.Id).ToList();
            for (int i = 0; i < terms.Count(); i++)
            {
                var ConditionsProvidedForms = new ConditionsProvidedForms()
                {
                    TermAndConditionId = terms[i].Id,
                    ProvidedFormId = data.Id,
                    IsAgree = false,
                    Attachments = null!

                };
                await _conditionFormsRepository.AddAsync(ConditionsProvidedForms);
            }
            var CycleConditions = _cycleConditionRepository.Where(c => c.CycleId == cycle.Id).ToList();
            
            for (int i = 0; i < CycleConditions.Count(); i++)
            {
                var CycleConditionsProvidedForms = new CycleConditionsProvidedForm()
                {
                    CycleConditionId = CycleConditions[i].Id,
                    ProvidedFormId = data.Id,
                    IsAgree = false,
                    Attachments = null!

                };
                await _cycleConditionsProvidedFormRepository.AddAsync(CycleConditionsProvidedForms);
            }
            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
