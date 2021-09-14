using ImageDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ImageDemo.Controllers
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
            return View();
        }

        [HttpGet]
        private string msg()
        {
            return "hello";
        }

        [HttpGet]
        public ContentResult msgnew(string name)
        {
            return Content("welcome "+name);
        }

        public void initialize()
        {
            ViewBag.Compname = "Kanini";
        }

        public EmptyResult init()
        {
            ViewBag.Compname = "Kanininew";
            return new EmptyResult();
        }
        public ViewResult Privacy()
        {
            //initialize();
            init();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
