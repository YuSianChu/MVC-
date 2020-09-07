using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC練習.Models;
using System.IO;



namespace MVC練習.Controllers
{


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            return View(new List<userModel>()
            {
              new userModel()
              {
                  Id = 1,
                  Name = "piggy",
                  Email = "piggy@XXX.XXXXXX"
              },
              new userModel()
              {
                    Id = 2,
                  Name = "piggy",
                  Email = "piggy@XXX.XXX"
              },
               new userModel()
               {
                   Id = 3,
                   Name = "piggy",
                   Email = "piggy@XXX.XXX"
               }
            });
            //HttpContext.Session.Keys.Contains("Piggy");

            //var user = new userModel();
            //user.Age += 30;
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult product()
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
