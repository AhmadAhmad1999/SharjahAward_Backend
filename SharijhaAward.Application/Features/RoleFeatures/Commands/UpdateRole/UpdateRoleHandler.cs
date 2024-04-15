using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.UpdateRole
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IMapper _Mapper;

        public UpdateRoleHandler(IMapper Mapper,
            IAsyncRepository<Role> RoleRepository)
        {
            _RoleRepository = RoleRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateRoleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Role? RoleEntityToUpdate = await _RoleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RoleEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Role is not found"
                    : "الدور غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Role? CheckRoleNameIfUnique = await _RoleRepository
                .FirstOrDefaultAsync(x => (x.ArabicName.ToLower() == Request.ArabicName.ToLower() ||
                    x.EnglishName.ToLower() == Request.EnglishName.ToLower()) &&
                    x.Id != Request.Id);

            if (CheckRoleNameIfUnique is not null)
            {
                if (CheckRoleNameIfUnique.ArabicName.ToLower() == Request.ArabicName.ToLower())
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Role's arabic name is already used, please insert a different name"
                        : "اسم الدور باللغة العربية مستخدم مسبقاً, الرجاء إدخال اسم مختلف";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
                else if (CheckRoleNameIfUnique.EnglishName.ToLower() == Request.EnglishName.ToLower())
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Role's english name is already used, please insert a different name"
                        : "اسم الدور باللغة الإنكليزية مستخدم مسبقاً, الرجاء إدخال اسم مختلف";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            _Mapper.Map(Request, RoleEntityToUpdate, typeof(UpdateRoleCommand), typeof(Role));

            await _RoleRepository.UpdateAsync(RoleEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Role has been updated successfully"
                : "تم تعديل الدور بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
