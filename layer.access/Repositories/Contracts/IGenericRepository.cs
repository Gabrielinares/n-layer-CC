using layer.access.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer.access.Repositories.Contracts
{
    public interface IGenericRepository<TModel> where TModel : class
    {
        Task<IEnumerable<TModel>> GetEmpleados();

        Task<TModel> AddEmpleado(TModel model);

        Task<Empleado> GetEmpleadoId(int id);
    }
}
