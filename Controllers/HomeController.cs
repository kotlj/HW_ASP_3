using HW_ASP_3.Services.FileNameGenerator;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFileNameGenerator _fileNameGenerator;

        public HomeController(ILogger<HomeController> logger, IFileNameGenerator fileNameGenerator)
        {
            _logger = logger;
            _fileNameGenerator = fileNameGenerator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FileNameGenerator()
        {
            ViewData["GenerateName"] = _fileNameGenerator.Random(10);
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
