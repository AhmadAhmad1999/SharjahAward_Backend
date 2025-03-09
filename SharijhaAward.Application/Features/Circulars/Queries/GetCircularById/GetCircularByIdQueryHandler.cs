using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CircularModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Circulars.Queries.GetCircularById
{
    public class GetCircularByIdQueryHandler
        : IRequestHandler<GetCircularByIdQuery, BaseResponse<CircularDto>>
    {
        private readonly IAsyncRepository<Circular> _CircularRepository;
        private readonly IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository;
        private readonly IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository;
        private readonly IAsyncRepository<CircularChairman> _CircularChairmanChairman;
        private readonly IAsyncRepository<CircularAttachment> _CircularAttachmentRepository;
        private readonly IAsyncRepository<CircularUser> _CircularUserRepository;
        private readonly IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IJwtProvider _JwtProvider;
        private readonly IMapper _Mapper;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetCircularByIdQueryHandler(IJwtProvider _JwtProvider, 
            IAsyncRepository<Circular> _CircularRepository, 
            IMapper _Mapper, 
            IAsyncRepository<CircularCoordinator> _CircularCoordinatorRepository, 
            IAsyncRepository<CircularArbitrator> _CircularArbitratorRepository, 
            IAsyncRepository<CircularChairman> _CircularChairmanChairman,
            IAsyncRepository<CircularAttachment> _CircularAttachmentRepository,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<CircularUser> _CircularUserRepository,
            IAsyncRepository<CiruclarSubcommitteeOfficer> _CiruclarSubcommitteeOfficerRepository,
            IAsyncRepository<UserRole> _UserRoleRepository)
        {
            this._CircularRepository = _CircularRepository;
            this._Mapper = _Mapper;
            this._CircularCoordinatorRepository = _CircularCoordinatorRepository;
            this._CircularArbitratorRepository = _CircularArbitratorRepository;
            this._CircularChairmanChairman = _CircularChairmanChairman;
            this._JwtProvider = _JwtProvider;
            this._CircularAttachmentRepository = _CircularAttachmentRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._CircularUserRepository = _CircularUserRepository;
            this._CiruclarSubcommitteeOfficerRepository = _CiruclarSubcommitteeOfficerRepository;
            this._UserRoleRepository = _UserRoleRepository;
        }

        public async Task<BaseResponse<CircularDto>> Handle(GetCircularByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.token!));

            Circular? CircularEntity = await _CircularRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CircularEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Circular is not found"
                    : "التعميم غير موجود";

                return new BaseResponse<CircularDto>(ResponseMessage, false, 404);
            }

            CircularDto Response = _Mapper.Map<CircularDto>(CircularEntity);

            if (!Request.View)
            {
                Response.Coordinators = await _CircularCoordinatorRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .Select(x => x.CoordinatorId)
                    .ToListAsync();

                Response.Arbitrators = await _CircularArbitratorRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .Include(x => x.Arbitrator)
                    .Select(x => x.ArbitratorId)
                    .ToListAsync();

                Response.Chairmans = await _CircularChairmanChairman
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .Select(x => x.ChairmanId)
                    .ToListAsync();

                Response.SubcommitteeOfficers = await _CiruclarSubcommitteeOfficerRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .Select(x => x.SubcommitteeOfficerId)
                    .ToListAsync();

                List<CircularUser> CircularUserEntities = await _CircularUserRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .ToListAsync();

                Response.ChairmanOfCommittes = CircularUserEntities
                    .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Chairman of Committees".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "رئيس اللجان")
                    .Select(x => x.UserRole!.UserId)
                    .ToList();

                Response.Experts = CircularUserEntities
                    .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Expert".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "خبير")
                    .Select(x => x.UserRole!.UserId)
                    .ToList();

                Response.Qualities = CircularUserEntities
                    .Where(x => x.UserRole!.Role!.EnglishName.ToLower() == "Quality".ToLower() &&
                        x.UserRole!.Role!.ArabicName == "الجودة")
                    .Select(x => x.UserRole!.UserId)
                    .ToList();

                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                Response.CircularAttachments = _Mapper.Map<List<CircularAttachmentDto>>(_CircularAttachmentRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .ToList()
                    .Select(x =>
                    {
                        return new CircularAttachmentDto()
                        {
                            AttachementPath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            CircularId = x.CircularId,
                            Id = x.Id,
                            FileName = x.FileName
                        };
                    }).ToList());

                return new BaseResponse<CircularDto>(string.Empty, true, 200, Response);
            }
            else
            {
                await _CircularCoordinatorRepository
                    .Where(x => x.CircularId == CircularEntity.Id &&
                        x.CoordinatorId == UserId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRead, true));

                await _CircularArbitratorRepository
                    .Where(x => x.CircularId == CircularEntity.Id &&
                        x.ArbitratorId == UserId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRead, true));

                await _CircularChairmanChairman
                    .Where(x => x.CircularId == CircularEntity.Id &&
                        x.ChairmanId == UserId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRead, true));

                await _CiruclarSubcommitteeOfficerRepository
                    .Where(x => x.CircularId == CircularEntity.Id &&
                        x.SubcommitteeOfficerId == UserId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRead, true));

                await _CircularUserRepository
                    .Where(x => x.CircularId == CircularEntity.Id &&
                        x.UserRole!.UserId == UserId)
                    .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRead, true));

                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string WWWRootFilePath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                Response.CircularAttachments = _Mapper.Map<List<CircularAttachmentDto>>(_CircularAttachmentRepository
                    .Where(x => x.CircularId == CircularEntity.Id)
                    .ToList()
                    .Select(x =>
                    {
                        return new CircularAttachmentDto()
                        {
                            AttachementPath = x.AttachementPath.Contains("wwwroot")
                                ? (WWWRootFilePath + x.AttachementPath.Split("wwwroot")[1]).Replace("\\", "/")
                                : x.AttachementPath.Replace("\\", "/"),
                            CircularId = x.CircularId,
                            Id = x.Id,
                            FileName = x.FileName
                        };
                    }).ToList());

                return new BaseResponse<CircularDto>(string.Empty, true, 200, Response);
            }
        }
    }
}
