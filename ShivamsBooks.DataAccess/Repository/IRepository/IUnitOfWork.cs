using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivamsBooks.DataAccess.Repository.IRepository
{
    interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ISP_Call SP_Call { get; }
    }
}
