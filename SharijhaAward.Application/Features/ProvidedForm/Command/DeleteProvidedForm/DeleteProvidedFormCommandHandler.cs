using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Command.DeleteProvidedForm
{
    public class DeleteProvidedFormCommandHandler
        : IRequestHandler<DeleteProvidedFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IUserRepository _userRepository;
        public DeleteProvidedFormCommandHandler(IAsyncRepository<Category> categoryRepository,  IUserRepository userRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteProvidedFormCommand request, CancellationToken cancellationToken)
        {
            string msg;

            var form = await _formRepository.GetByIdAsync(request.providedFormId);
           
            if (form == null)
            {
                msg = request.lang == "en"
                    ? "Provided Form dose not Exist"
                    : "لا يوجد إستمارة ";

                return new BaseResponse<object>(msg, false, 404);
            }

            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == form!.categoryId);
            var user = await _userRepository.GetByIdAsync(form.userId);


            if (category!.CategoryClassification == Domain.Constants.CategoryConstants.CategoryClassification.Individual)
                user!.NumberOfIndividualCategories--;
            else
                user!.NumberOfGroupCategories--;

            await _formRepository.DeleteAsync(form);

            msg = request.lang == "en"
                   ? "Provided Form has been Deleted"
                   : "تم حذف الإستمارة بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
