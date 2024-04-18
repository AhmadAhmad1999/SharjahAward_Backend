using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Circulars.Command.CreateCircular
{
    public class CreateCircularCommandHandler
        : IRequestHandler<CreateCircularCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateCircularCommandHandler(IMapper mapper, IAsyncRepository<Circular> circularRepository, IFileService fileService)
        {
            _mapper = mapper;
            _circularRepository = circularRepository;
            _fileService = fileService;
        }
        public async Task<BaseResponse<int>> Handle(CreateCircularCommand request, CancellationToken cancellationToken)
        {
            
            var Circular = _mapper.Map<Circular>(request);

            if(request.ArabicFile != null)
            {
                Circular.ArabicFileUrl = await _fileService.SaveFileAsync(request.ArabicFile);
            }
            if(request.EnglishFile != null)
            {
                Circular.EnglishFileUrl = await _fileService.SaveFileAsync(request.EnglishFile);
            }

            var data = await _circularRepository.AddAsync(Circular);

            string msg = request.lang == "en"
                ? "Circular has benn Created"
                : "تم إضافة التعميم";

            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
