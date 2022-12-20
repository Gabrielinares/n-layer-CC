using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using layer.access.models;
using layer.access.Repositories.Contracts;
using layer.business.Services.Contracts;

namespace layer.business.Services
{
    public class EmpleadoServicio : IEmpleadoServicio
    {
        private readonly IGenericRepository<Empleado> _repository;

        public EmpleadoServicio(IGenericRepository<Empleado> repository)
        {
            _repository = repository;
        }

        public async Task<List<Empleado>> GetEmpleados()
        {
            try
            {
                return (List<Empleado>)await _repository.GetEmpleados();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Empleado> AddEmpleado(Empleado empleado)
        {
            try
            {
                return await _repository.AddEmpleado(empleado);
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
                return await _repository.GetEmpleadoId(id);
            }
            catch
            {
                throw;
            }
        }
    }
}
