using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Commands.UpdateIndex
{
    public class UpdateIndexCommandHandler
        : IRequestHandler<UpdateIndexCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.IndexModel.Index> _indexRepository;
        private readonly IMapper _mapper;

        public UpdateIndexCommandHandler(IAsyncRepository<Domain.Entities.IndexModel.Index> indexRepository, IMapper mapper)
        {
            _indexRepository = indexRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateIndexCommand request, CancellationToken cancellationToken)
        {
            string msg = "";
            var index = await _indexRepository.GetByIdAsync(request.Id);

            if (index == null)
            {
                msg = request.lang == "en"
                    ? "Index not Found"
                    : "الفهرس غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, index, typeof(UpdateIndexCommand), typeof(Domain.Entities.IndexModel.Index));


            await _indexRepository.UpdateAsync(index);

            msg = request.lang == "en"
               ? "Index has been Updated"
               : "تم تعديل الفهرس بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
