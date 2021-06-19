using Microsoft.EntityFrameworkCore;
using NShop.Data.EF;
using NShop.Data.Entities;
using NShop.Models.Common;
using NShop.Models.Languages;
using NShop.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Repositories
{
    public interface ILanguageRepository : IRepository<Language>
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }

    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {

        private readonly NShopDbContext _context;

        public LanguageRepository(IDbFactory dbFactory, NShopDbContext context) : base(dbFactory)
        {
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Languages.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name,
                IsDefault = x.IsDefault
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }

    }
}
