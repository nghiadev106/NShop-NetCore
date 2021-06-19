using NShop.Models.Common;
using NShop.Models.Users;
using NShop.Repositories;
using NShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ApiResult<string>> Authencate(LoginRequest request)
        {
            return await _userRepository.Authencate(request);
        }

        public async Task<ApiResult<bool>> Delete(Guid id)
        {
            return await _userRepository.Delete(id);
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<ApiResult<PagedResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request)
        {
            return await _userRepository.GetUsersPaging(request);
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            return await _userRepository.Register(request);
        }

        public async Task<ApiResult<bool>> RoleAssign(Guid id, RoleAssignRequest request)
        {
            return await _userRepository.RoleAssign(id,request);
        }

        public async Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request)
        {
            return await _userRepository.Update(id,request);
        }
    }
}
