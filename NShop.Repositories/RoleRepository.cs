using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NShop.Data.EF;
using NShop.Data.Entities;
using NShop.Models.Roles;
using NShop.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NShop.Repositories
{
    public interface IRoleRepository : IRepository<AppRole>
    {
        Task<List<RoleVm>> GetAll();
    }

    public class RoleRepository : RepositoryBase<AppRole>, IRoleRepository
    {

        private readonly NShopDbContext _context;
        private readonly RoleManager<AppRole> _roleManager;

        public RoleRepository(IDbFactory dbFactory, NShopDbContext context, RoleManager<AppRole> roleManager) : base(dbFactory)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public async Task<List<RoleVm>> GetAll()
        {
            var roles = await _roleManager.Roles
                .Select(x => new RoleVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description
                }).ToListAsync();

            return roles;
        }

    }
}
