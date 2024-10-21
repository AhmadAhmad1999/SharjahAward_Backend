using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.CreateTemplate
{
    public class CreateTemplateHandler : IRequestHandler<CreateTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Template> _TemplateRepository;

        public CreateTemplateHandler(IMapper Mapper,
            IAsyncRepository<Template> _TemplateRepository)
        {
            _Mapper = Mapper;
            this._TemplateRepository = _TemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (Request.isActive)
                    {
                        Template? ActiveTemplateEntity = await _TemplateRepository
                            .FirstOrDefaultAsync(x => x.isActive);

                        if (ActiveTemplateEntity is not null)
                        {
                            ActiveTemplateEntity.isActive = false;
                            await _TemplateRepository.UpdateAsync(ActiveTemplateEntity);
                        }
                    }

                    Template NewTemplateEntity = _Mapper.Map<Template>(Request);

                    await _TemplateRepository.AddAsync(NewTemplateEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء النموذج بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
