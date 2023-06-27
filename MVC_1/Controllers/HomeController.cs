using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_1.Models;
using System.Diagnostics;

namespace MVC_1.Controllers
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
            Student student = new Student
            {
                Id = 1,
                Name = "Shehan",
                City = "Colombo"
            };

            return View(student);
        }

        public IActionResult Privacy()
        {
            Details details = new Details
            {
                NIC = "189987678V",
                Birthday = "1999/12/14"
            };

            return View(details);
        }

        public IActionResult ContactUs()
        {
            Contact contact = new Contact
            {
                Tp = "0785566783"
            };
            return View(contact);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var errorViewModel = new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };

            return View(errorViewModel);
        }
    }
}
