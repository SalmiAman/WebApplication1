using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
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
            List<Menu> menus = new List<Menu>
                {
                    new Menu { ActionName = "index", ControllerName = "marketing", Id = 1, MenuIcon = "bi bi-grid", 
                    MenuId = 1, MenuName = "Dashboard", MenuOrder = null, ParentId = null, ParentName = null },
                    new Menu { ActionName = "", ControllerName = "", Id = 3, MenuIcon = "bi bi-menu-button-wide", 
                    MenuId = 2, MenuName = "Sales Contract Setup", MenuOrder = null, ParentId = null, ParentName = null },
                    new Menu { ActionName = "EstateCommodity", ControllerName = "marketing", Id = 2, MenuIcon = "bi bi-circle", 
                    MenuId = 3, MenuName = "Estate Commodity", MenuOrder = 1, ParentId = 2, ParentName = null }
                };

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
