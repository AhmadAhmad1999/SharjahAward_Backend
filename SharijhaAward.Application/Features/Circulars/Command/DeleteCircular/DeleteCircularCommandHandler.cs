using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.DeleteCircular
{
    public class DeleteCircularCommandHandler
        : IRequestHandler<DeleteCircularCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;

        public DeleteCircularCommandHandler(IAsyncRepository<Circular> circularRepository)
        {
            _circularRepository = circularRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCircularCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Circular has been Deleted"
                : "تم حذف التعميم";

            var CircularToDelete = await _circularRepository.GetByIdAsync(request.Id);

            if(CircularToDelete == null)
            {
                msg = request.lang == "en"
                ? "Circular Not found"
                : "التعميم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _circularRepository.DeleteAsync(CircularToDelete);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
