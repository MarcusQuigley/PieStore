using Microsoft.AspNetCore.Mvc;
using PieShopSite.Services;
using PieShopSite.ViewModels;
using System;
using System.Linq;
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

        public IActionResult List(string category)
        {
            var viewModel = new PiesListViewModel();
            if (string.IsNullOrEmpty(category))
            {
                viewModel.Pies = pieRepository.AllPies;
                viewModel.CurrentCategory = "All pies";
            }
            else
            {
                viewModel.Pies = pieRepository.AllPies.Where(p => p.Category.CategoryName == category);
                viewModel.CurrentCategory = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
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

        //public IActionResult List(int categoryId)
        //{

        //}
    }

}
