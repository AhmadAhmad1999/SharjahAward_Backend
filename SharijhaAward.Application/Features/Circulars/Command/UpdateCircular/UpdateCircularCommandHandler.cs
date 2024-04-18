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

namespace SharijhaAward.Application.Features.Circulars.Command.UpdateCircular
{
    public class UpdateCircularCommandHandler
        : IRequestHandler<UpdateCircularCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Circular> _circularRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateCircularCommandHandler(IAsyncRepository<Circular> circularRepository, IFileService fileService, IMapper mapper)
        {
            _circularRepository = circularRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCircularCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Circular has been Updated"
                : "تم تعديل التعميم";

            var CircularToUpdate = await _circularRepository.GetByIdAsync(request.Id);
            
            if(CircularToUpdate == null)
            {
                msg = request.lang == "en"
                ? "Circular Not found"
                : "التعيم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var arabicFile = CircularToUpdate.ArabicFileUrl;
            var englishFile = CircularToUpdate.EnglishFileUrl;

            _mapper.Map(request, CircularToUpdate, typeof(UpdateCircularCommand), typeof(Circular));


            if(request.updateOnEnglishFile)
                CircularToUpdate.EnglishFileUrl = await _fileService.SaveFileAsync(request.englishFile!);
            else
                CircularToUpdate.EnglishFileUrl = englishFile;

            if (request.updateOnArabicFile)
                CircularToUpdate.ArabicFileUrl = await _fileService.SaveFileAsync(request.arabicFile!);
            else
                CircularToUpdate.ArabicFileUrl = arabicFile;

            await _circularRepository.UpdateAsync(CircularToUpdate);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
