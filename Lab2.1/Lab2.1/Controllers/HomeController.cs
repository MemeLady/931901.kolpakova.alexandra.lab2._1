using Lab2._1.Models;
using Lab2._1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassUsingModel()
        {
            var viewModel = new PassUsingModel();
            return View(viewModel);
        }

        public IActionResult PassUsingViewData()
        {
            @ViewData["Nums"] = new Calc();
            return View();
        }

        public IActionResult PassUsingViewBag()
        {
            ViewBag.Nums = new PassUsingModel();
            return View();
        }

        public IActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
