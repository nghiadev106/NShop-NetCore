using NShop.Models.Categories;
using NShop.Repositories;
using NShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            return await _categoryRepository.GetAll(languageId);
        }

        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            return await _categoryRepository.GetById(languageId,id);
        }
    }
}
