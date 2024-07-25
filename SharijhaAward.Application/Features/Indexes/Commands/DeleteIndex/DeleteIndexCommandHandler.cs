using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Commands.DeleteIndex
{
    public class DeleteIndexCommandHandler
        : IRequestHandler<DeleteIndexCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.IndexModel.Index> _indexRepository;

        public DeleteIndexCommandHandler(IAsyncRepository<Domain.Entities.IndexModel.Index> indexRepository)
        {
            _indexRepository = indexRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteIndexCommand request, CancellationToken cancellationToken)
        {
            string msg = "";

            var index = await _indexRepository.GetByIdAsync(request.Id);

            if(index == null)
            {
                msg = request.lang == "en"
                    ? "Index not Found"
                    : "الفهرس غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _indexRepository.DeleteAsync(index);

            msg = request.lang == "en"
               ? "Index has been Deleted"
               : "تم حذف الفهرس بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
