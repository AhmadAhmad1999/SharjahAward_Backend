using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.DeletePage
{
    public class DeletePageCommandHandler
        : IRequestHandler<DeletePageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageStructure> _pageStructureRepository;

        public DeletePageCommandHandler(IAsyncRepository<PageStructure> pageStructureRepository)
        {
            _pageStructureRepository = pageStructureRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeletePageCommand request, CancellationToken cancellationToken)
        {
            string msg = "";

            var page = await _pageStructureRepository.GetByIdAsync(request.Id);
            
            if(page == null)
            {
                msg = request.lang == "en"
                    ? "Page not Found"
                    : "الصفحة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            if (!page.Deletable)
            {
                msg = request.lang == "en"
                    ? "You Can't Delete This Page"
                    : "لا يمكنك حذف هذه الصفحة";

                return new BaseResponse<object>(msg, true, 400);
            }

            await _pageStructureRepository.DeleteAsync(page);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
