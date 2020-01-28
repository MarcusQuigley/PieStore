using PieShopSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShopSite.Services.MockRepos
{
    public class CategoryRepository : ICategoryRepository
    {
        readonly PieContext dbContext;
        public CategoryRepository(PieContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public IEnumerable<Category> AllCategories => dbContext.Categories;
    }
}
