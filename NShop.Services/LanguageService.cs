using NShop.Models.Common;
using NShop.Models.Languages;
using NShop.Repositories;
using NShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository _languageRepository;

        public LanguageService(ILanguageRepository languageRepository)
        {
            _languageRepository = languageRepository;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            return await _languageRepository.GetAll();
        }
    }
}
