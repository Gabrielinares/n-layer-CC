using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using layer.access.models;

namespace layer.business.Services.Contracts
{
    public interface IEmpleadoServicio
    {
        Task<List<Empleado>> GetEmpleados();

        Task<Empleado> AddEmpleado(Empleado empleado);

        Task<Empleado> EditEmpleado(Empleado empleado);

        Task<Empleado> EliminarEmpleado(int id);

        Task<Empleado> GetEmpleadoId(int id);
    }
}
