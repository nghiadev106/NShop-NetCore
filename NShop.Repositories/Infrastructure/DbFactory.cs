using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NShop.Data.EF;

namespace NShop.Repositories.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DbContextOptions<NShopDbContext> _options;
        NShopDbContext dbContext;

        public DbFactory(DbContextOptions<NShopDbContext> options)
        {
            _options = options;
        }

        public NShopDbContext Init()
        {
            return dbContext ?? (dbContext = new NShopDbContext(_options));
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
