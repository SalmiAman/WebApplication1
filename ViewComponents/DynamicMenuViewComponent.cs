using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.ViewComponents
{
    public class DynamicMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
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

       

            return View(menus);
        }

    }
}
