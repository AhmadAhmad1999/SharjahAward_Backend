using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IndexModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Indexes.Commands.CreateIndex
{
    public class CreateIndexCommandHandler
        : IRequestHandler<CreateIndexCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.IndexModel.Index> _indexRespository;
        private readonly IMapper _mapper;

        public CreateIndexCommandHandler(IAsyncRepository<Domain.Entities.IndexModel.Index> indexRespository, IMapper mapper)
        {
            _indexRespository = indexRespository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<object>> Handle(CreateIndexCommand request, CancellationToken cancellationToken)
        {

            var index = _mapper.Map<Domain.Entities.IndexModel.Index>(request);

            var slug = request.Slug == null
                ? request.EnglishName
                : request.Slug;

            slug = slug.ToLower();
            index.Slug = slug.Replace(" ", "_");

            await _indexRespository.AddAsync(index);

            string msg = request.lang == "en"
                ? "Index has been Added"
                : "تمت إضافة الفهرس";

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
