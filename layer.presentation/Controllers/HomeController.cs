using layer.presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using layer.business.Services.Contracts;
using layer.access.models;

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}