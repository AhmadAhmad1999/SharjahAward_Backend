﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
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
        private readonly IAsyncRepository<TermAndCondition> _termRepository;       
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _mapper;

        public CreateProvidedFormCommandHandler(
            IJwtProvider JwtProvider, 
            IAsyncRepository<ConditionsProvidedForms> conditionFormsRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedrepository,
            IAsyncRepository<Cycle> cyclerepository, IAsyncRepository<Category> categoryrepository,
            IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IMapper mapper,
            IAsyncRepository<TermAndCondition> termRepository
            )
        {
            _Providedrepository = providedrepository;
            _CycleRepository = cyclerepository;
            _JwtProvider = JwtProvider;
            _CategoryRepository = categoryrepository;
            _conditionFormsRepository = conditionFormsRepository;
            _UserRepository = userRepository;
            _termRepository = termRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateProvidedFormCommand request, CancellationToken cancellationToken)
        {
            var UserId = _JwtProvider.GetUserIdFromToken(request.token);

            if(UserId == null)
            {
                return new BaseResponse<int>("Invalid Token", false, 400);
            }
            var category =await _CategoryRepository.GetByIdAsync(request.categoryId);
            var cycle = await _CycleRepository.GetByIdAsync(category.CycleId);

            var ProvidedForm = _mapper.Map<Domain.Entities.ProvidedFormModel.ProvidedForm>(request);
            ProvidedForm.userId = new Guid(UserId);
            ProvidedForm.CycleNumber = cycle.CycleNumber;
            ProvidedForm.CycleYear = cycle.Year;
            ProvidedForm.Type = 0;
            ProvidedForm.Status = 0;
            ProvidedForm.CurrentStep = 1;
            ProvidedForm.TotalStep = 7;
            ProvidedForm.PercentCompletion = (ProvidedForm.CurrentStep * 100) / ProvidedForm.TotalStep;

            
            var data =  await _Providedrepository.AddAsync(ProvidedForm);

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
            return new BaseResponse<int>("", true, 200, data.Id);
        }
    }
}
