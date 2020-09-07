using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC練習.Controllers
{
    public class ChuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ninenine(int countx=9 ,int county=9)
        {
            ViewData["MaxX"] = countx;
            ViewData["MaxY"] = county;
            return View();
        }
        public IActionResult lotto()
        {
            return View();
        }
        public IActionResult fib()
        {
            return View();
        }
     
    }
}
