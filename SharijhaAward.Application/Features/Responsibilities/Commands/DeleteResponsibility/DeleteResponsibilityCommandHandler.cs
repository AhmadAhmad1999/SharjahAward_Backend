using MediatR;
using Microsoft.EntityFrameworkCore.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Commands.DeleteResponsibility
{
    public class DeleteResponsibilityCommandHandler
        : IRequestHandler<DeleteResponsibilityCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;
        
        public async Task<BaseResponse<object>> Handle(DeleteResponsibilityCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Responsibility has been Deleted"
                : "تم حذف المسؤولية";

            var Responsibility = await _responsibilityRepository.GetByIdAsync(request.Id);
            
            if(Responsibility == null)
            {
                msg = request.lang == "en"
                ? "Responsibility not found"
                : "المسؤولية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _responsibilityRepository.DeleteAsync(Responsibility);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
