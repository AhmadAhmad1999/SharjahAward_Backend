using AutoMapper;
using MediatR;
using OpenQA.Selenium.DevTools.V119.Browser;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.RewardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Commands.CreateReward
{
    public class CreateRewardCommandHandler
        : IRequestHandler<CreateRewardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateRewardCommandHandler(IAsyncRepository<Reward> rewardRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _rewardRepository = rewardRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateRewardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Reward has been Added"
                : "تم إضافة المكافئة";

            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.CategoryId);
           
            if (category == null )
            {
                msg = request.lang == "en"
                ? "Category not Found "
                : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }    
            if (category.ParentId == null)
            {
                msg = request.lang == "en"
                ? "This is Main Category"
                : "هذه الفئة رئيسية";

                return new BaseResponse<object>(msg, false, 400);
            }

            var reward = _mapper.Map<Reward>(request);

            await _rewardRepository.AddAsync(reward);

            return new BaseResponse<object>(msg, true, 200);
            
        }
    }
}
