using ShivamsBooks.DataAccess.Repository.IRepository;
using ShivamsBooks.Models;
using ShivamsBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivamsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>,  ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
