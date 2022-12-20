using layer.presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using layer.business.Services.Contracts;
using layer.access.models;
using Microsoft.EntityFrameworkCore;

namespace layer.presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmpleadoServicio _empleadoServicio;

        public HomeController(IEmpleadoServicio empleadoServicio)
        {
            _empleadoServicio= empleadoServicio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> mostrarEmpleados()
        {
            List<Empleado> listEmpleados = await _empleadoServicio.GetEmpleados();
            return View(listEmpleados);
        }

        public IActionResult VAddEmpleado()
        {
            return View();
        }

        public async Task<IActionResult> AddEmpleado([FromForm]Empleado empleado)
        {
            await _empleadoServicio.AddEmpleado(empleado);
            return View("mostrarEmpleados");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}