using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreStockChart.Models;

namespace NetCoreStockChart.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Stock Application based on ASPNetCore.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "AdvancedProgramming Project";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult StockChart()
        {
            return View();
        }
    }
}
