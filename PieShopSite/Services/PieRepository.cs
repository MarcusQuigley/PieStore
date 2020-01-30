using Microsoft.EntityFrameworkCore;
using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Services
{
    public class PieRepository : IPieRepository
    {
       //   readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        readonly PieContext dbContext;
        
        public PieRepository(PieContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<Pie> AllPies => dbContext.Pies.Include(p => p.Category);


        public IEnumerable<Pie> PiesOfWeek => dbContext.Pies.Include(p => p.Category).Where(p => p.IsPieOfTheWeek);

        public Pie GetPie(int id)
        {
            return dbContext.Pies.SingleOrDefault(p => p.PieId == id);
        }
    }
}
