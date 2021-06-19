using NShop.Models.Roles;
using NShop.Repositories;
using NShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<RoleVm>> GetAll()
        {
            return await _roleRepository.GetAll();
        }
    }
}
