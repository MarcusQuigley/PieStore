using Microsoft.AspNetCore.Mvc;
using PieShopSite.Services;
using PieShopSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public ViewResult List()
        {
            var viewModel = new PiesListViewModel();
            viewModel.Pies = pieRepository.AllPies;
            viewModel.CurrentCategory = "Cheese cakes";
            return View(viewModel);
        }
    }

}
