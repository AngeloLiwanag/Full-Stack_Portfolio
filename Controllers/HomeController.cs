using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FullStack_portfolio.Models;

namespace FullStack_portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
