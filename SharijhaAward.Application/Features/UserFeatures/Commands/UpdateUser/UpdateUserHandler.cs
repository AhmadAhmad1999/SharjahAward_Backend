﻿using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Commands.UpdateClass;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand2, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public UpdateUserHandler(IMapper Mapper,
            IUserRepository UserRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateUserCommand2 Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntityToUpdate = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User? CheckIfEmailIsAlreadyUsed = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() &&
                    x.Id != Request.Id);

            if (CheckIfEmailIsAlreadyUsed is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This email is already used"
                    : "البريد الإلكتروني مستخدم بالفعل";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            List<int> AlreadyExistRoleIds = await _UserRoleRepository
                .Where(x => x.UserId == Request.Id)
                .Select(x => x.RoleId)
                .ToListAsync();

            List<int> IntersectRoleIds = AlreadyExistRoleIds
                .Intersect(Request.RolesIds).ToList();

            List<int> NewRoleIds = Request.RolesIds
                .Where(x => !IntersectRoleIds.Contains(x))
                .ToList();

            List<int> DeleteRoleIds = AlreadyExistRoleIds
                .Where(x => !IntersectRoleIds.Contains(x))
                .ToList();

            List<UserToken> AllUserTokenEntities = await _UserTokenRepository
                .Where(x => x.UserId == Request.Id)
                .ToListAsync();

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
                    IQueryable<UserRole> DeleteUserRoleEntites = _UserRoleRepository
                        .Where(x => x.UserId == Request.Id &&
                            DeleteRoleIds.Contains(x.RoleId));

                    if (DeleteUserRoleEntites.Count() > 0)
                        await _UserRoleRepository.DeleteListAsync(DeleteUserRoleEntites);

                    IEnumerable<UserRole> NewUserRoleEntites = NewRoleIds
                        .Select(x => new UserRole()
                        {
                            UserId = Request.Id,
                            RoleId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewUserRoleEntites.Count() > 0)
                        await _UserRoleRepository.AddRangeAsync(NewUserRoleEntites);

                    if (AllUserTokenEntities.Any())
                        await _UserTokenRepository.DeleteListAsync(AllUserTokenEntities);

                    _Mapper.Map(Request, UserEntityToUpdate, typeof(UpdateUserCommand2), typeof(Domain.Entities.IdentityModels.User));

                    await _UserRepository.UpdateAsync(UserEntityToUpdate);

                    ResponseMessage = Request.lang == "en"
                       ? "User has been updated successfully"
                       : "تم تعديل المستخدم بنجاح";

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
