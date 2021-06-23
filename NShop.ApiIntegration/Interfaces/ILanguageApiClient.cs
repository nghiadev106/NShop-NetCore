using NShop.Models.Common;
using NShop.Models.Languages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NShop.ApiIntegration.Interfaces
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
