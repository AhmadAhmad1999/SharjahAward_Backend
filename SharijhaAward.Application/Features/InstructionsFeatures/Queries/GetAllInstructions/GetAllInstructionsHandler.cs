using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InstructionModel;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Queries.GetAllInstructions
{
    public class GetAllInstructionsHandler : IRequestHandler<GetAllInstructionsQuery, BaseResponse<List<GetAllInstructionsListVM>>>
    {
        private readonly IAsyncRepository<Instruction> _InstructionRepository;
        private readonly IMapper _Mapper;
        public GetAllInstructionsHandler(IAsyncRepository<Instruction> InstructionRepository,
            IMapper Mapper)
        {
            _InstructionRepository = InstructionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<List<GetAllInstructionsListVM>>> Handle(GetAllInstructionsQuery Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllInstructionsListVM> Instructions = _Mapper.Map<List<GetAllInstructionsListVM>>(await _InstructionRepository
                .GetPagedReponseAsync(Request.page, Request.pageSize));

            int TotalCount = await _InstructionRepository.GetCountAsync(null);

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllInstructionsListVM>>(ResponseMessage, true, 200, Instructions, PaginationParameter);
        }
    }
}
