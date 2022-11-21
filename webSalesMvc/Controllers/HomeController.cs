using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webSalesMvc.Models;

namespace webSalesMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
         
        public IActionResult Index()
        {
            ViewData["Nome"] = "Rian Sousa Florentino das Chagas";
            ViewData["Messagem"] = "Mensagem vinda diretamente do controlador!";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}