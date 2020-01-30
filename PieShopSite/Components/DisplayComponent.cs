using Microsoft.AspNetCore.Mvc;
using PieShopSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Components
{
    public class DisplayComponent : ViewComponent
    {
        readonly ICategoryRepository categoryService;
        public DisplayComponent(ICategoryRepository categoryService)
        {
            this.categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }
        public IViewComponentResult Invoke()
        {
            var categories = categoryService.AllCategories;
            return View(categories);
        }
    }
}
