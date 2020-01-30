using PieShopSite.Models;
using System.Collections.Generic;

namespace PieShopSite.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfWeek { get; set; }
    }
}
