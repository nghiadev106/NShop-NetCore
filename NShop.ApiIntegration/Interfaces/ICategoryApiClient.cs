using NShop.Models.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NShop.ApiIntegration.Interfaces
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}
