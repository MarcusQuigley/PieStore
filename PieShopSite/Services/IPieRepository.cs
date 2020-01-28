using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Services
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get;  }
        IEnumerable<Pie> PiesOfWeek { get;  }
        Pie GetPie(int id);
    }
}
