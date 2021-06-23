using NShop.Models.Common;
using NShop.Models.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NShop.ApiIntegration.Interfaces
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}
