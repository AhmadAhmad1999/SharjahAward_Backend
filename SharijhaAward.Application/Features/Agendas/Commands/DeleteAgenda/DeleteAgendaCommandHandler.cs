using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AgendaModel;

namespace SharijhaAward.Application.Features.Agendas.Commands.DeleteAgenda
{
    public class DeleteAgendaCommandHandler
        : IRequestHandler<DeleteAgendaCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Agenda> _agendaRepository;

        public DeleteAgendaCommandHandler(IAsyncRepository<Agenda> agendaRepository)
        {
            _agendaRepository = agendaRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAgendaCommand request, CancellationToken cancellationToken)
        {
            var agendaToDelete = await _agendaRepository.GetByIdAsync(request.Id);
            string msg;
            if (agendaToDelete == null)
            {
                msg = request.lang == "en"
                    ? "Agenda is Not Found"
                    : "الأجندة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _agendaRepository.DeleteAsync(agendaToDelete);
            msg = request.lang == "en"
                ? "Agenda has been Deleted"
                : "تم حذف الأجندة";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
