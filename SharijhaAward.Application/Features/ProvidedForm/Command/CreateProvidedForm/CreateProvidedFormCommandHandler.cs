using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
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
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _mapper;

        public CreateProvidedFormCommandHandler(IJwtProvider JwtProvider, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedrepository, IAsyncRepository<Cycle> cyclerepository, IAsyncRepository<Category> categoryrepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IMapper mapper)
        {
            _Providedrepository = providedrepository;
            _CycleRepository = cyclerepository;
            _JwtProvider = JwtProvider;
            _CategoryRepository = categoryrepository;
            _UserRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateProvidedFormCommand request, CancellationToken cancellationToken)
        {
            var UserId = _JwtProvider.GetUserIdFromToken(request.token);
            var category =await _CategoryRepository.GetByIdAsync(request.categoryId);
            var cycle = await _CycleRepository.GetByIdAsync(category.CycleId);

            var ProvidedForm = _mapper.Map<Domain.Entities.ProvidedFormModel.ProvidedForm>(request);
            ProvidedForm.userId = new Guid(UserId);
            ProvidedForm.CycleNumber = cycle.CycleNumber;
            ProvidedForm.CycleYear = cycle.Year;
            ProvidedForm.PercentCompletion = 5;
            ProvidedForm.Type = 0;
            ProvidedForm.Status = 0;
            ProvidedForm.CurrentStep = 1;

            var data =  await _Providedrepository.AddAsync(ProvidedForm);
            
            return new BaseResponse<int>("", true, 200, data.Id);
        }
    }
}
