using System;
using System.Collections.Generic;
using System.Text;

namespace NShop.Repositories.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
