using Microsoft.AspNetCore.Mvc;
using PieShopSite.Services;
using PieShopSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Controllers
{
    public class HomeController : Controller
    {
        readonly IPieRepository pieService;

        public HomeController(IPieRepository pieService)
        {
            this.pieService = pieService ?? throw new ArgumentNullException(nameof(pieService));
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfWeek = pieService.PiesOfWeek
            };
            return View(homeViewModel);
        }
    }
}
