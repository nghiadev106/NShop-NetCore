using NShop.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Repositories.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        NShopDbContext Init();
    }
}
