using Microsoft.AspNetCore.Mvc;
using PieShopSite.Services;
using PieShopSite.ViewModels;
using System;

namespace PieShopSite.Controllers
{
    public class PieController : Controller
    {
        readonly IPieRepository pieRepository;
        readonly ICategoryRepository categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            this.pieRepository = pieRepository ?? throw new ArgumentNullException(nameof(pieRepository));
            this.categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        }

        public IActionResult List()
        {
            var viewModel = new PiesListViewModel();
            viewModel.Pies = pieRepository.AllPies;
            viewModel.CurrentCategory = "Cheese cakes";
            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            var pie = pieRepository.GetPie(id);
            if (pie == null)
            {
                return NotFound();
            }
             return View(pie);
        }
    }

}
