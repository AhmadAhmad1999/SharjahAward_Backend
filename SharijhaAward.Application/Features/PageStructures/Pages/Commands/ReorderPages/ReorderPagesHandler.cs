using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModel;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.ReorderPages
{
    public class ReorderPagesHandler : IRequestHandler<ReorderPagesCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<PageStructure> _PageStructureRepository;
        public ReorderPagesHandler(IAsyncRepository<PageStructure> _PageStructureRepository)
        {
            this._PageStructureRepository = _PageStructureRepository;
        }
        public async Task<BaseResponse<object>> Handle(ReorderPagesCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<PageStructure> PageStructureEntities = await _PageStructureRepository
                .Where(x => Request.InsideCells.AsEnumerable().Select(y => y.Id).Contains(x.Id) ||
                    Request.OutsideCells.AsEnumerable().Select(y => y.Id).Contains(x.Id))
                .ToListAsync();

            foreach (PageStructure PageStructureEntity in PageStructureEntities)
            {
                if (Request.InsideCells.Select(z => z.Id).Contains(PageStructureEntity.Id))
                {
                    PageStructureEntity.orderId = Request.InsideCells
                        .FirstOrDefault(x => x.Id == PageStructureEntity.Id)!.OrderId;

                    PageStructureEntity.PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InCells;
                }
                else
                {
                    PageStructureEntity.orderId = Request.OutsideCells
                        .FirstOrDefault(x => x.Id == PageStructureEntity.Id)!.OrderId;

                    PageStructureEntity.PagePostion = Domain.Constants.CustomPageConstants.PagePostion.InMenu;
                }
            }

            await _PageStructureRepository.UpdateListAsync(PageStructureEntities);

            ResponseMessage = Request.lang == "en"
                ? "Updated successfully"
                : "تم تعديل ترتيب الصفحات بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
