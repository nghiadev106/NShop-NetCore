using NShop.Models.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services.Interfaces
{
    public interface IRoleService
    {
        Task<List<RoleVm>> GetAll();
    }
}
