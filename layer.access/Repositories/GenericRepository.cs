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
                await _dbcontext.SaveChangesAsync();

                return await _dbcontext.Set<TModel>().ToListAsync();
            }
            catch
            {
                throw;
            }
        }

        public async Task<TModel> AddEmpleado(TModel model)
        {
            try
            {
                _dbcontext.Add(model);
                _dbcontext.SaveChanges();
                return model;
            }
            catch
            {
                throw;
            }
        }

        public async Task<TModel> EditEmpleado(TModel model)
        {
            try
            {
                _dbcontext.Update(model);
                _dbcontext.SaveChanges();
                return model;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Empleado> GetEmpleadoId(int id)
        {
            try
            {
                return await _dbcontext.Empleados.FirstOrDefaultAsync(m => m.IdEmpleado == id);
            }
            catch
            {
                throw;
            }
        }

    }
}
