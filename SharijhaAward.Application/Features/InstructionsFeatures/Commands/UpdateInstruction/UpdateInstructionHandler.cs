using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InstructionModel;

namespace SharijhaAward.Application.Features.InstructionsFeatures.Commands.UpdateInstruction
{
    public class UpdateInstructionHandler : IRequestHandler<UpdateInstructionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Instruction> _InstructionRepository;
        private readonly IMapper _Mapper;

        public UpdateInstructionHandler(IMapper Mapper,
            IAsyncRepository<Instruction> InstructionRepository)
        {
            _InstructionRepository = InstructionRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateInstructionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Instruction? InstructionEntityToUpdate = await _InstructionRepository
                .FirstOrDefaultAsync(x => x.Slug.ToLower() == Request.Slug.ToLower());

            if (InstructionEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Instruction is not found"
                    : "الإرشاد غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, InstructionEntityToUpdate, typeof(UpdateInstructionCommand), typeof(Instruction));

            await _InstructionRepository.UpdateAsync(InstructionEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Instruction has been updated successfully"
                : "تم تعديل الإرشاد بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
