using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using layer.access.DataContext;
using layer.access.models;
using layer.access.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace layer.access.Repositories
{
    public class GenericRepository<TModel> : IGenericRepository<TModel> where TModel : class
    {
        private readonly TestDbContext _dbcontext;
        public GenericRepository(TestDbContext dbcontext)
        {
            _dbcontext = dbcontext; 
        }

        public async Task<IEnumerable<TModel>> GetEmpleados()
        {
            try
            {
                return await _dbcontext.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
