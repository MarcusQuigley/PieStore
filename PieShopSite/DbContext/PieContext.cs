using Microsoft.EntityFrameworkCore;
using PieShopSite.Models;

namespace PieShopSite
{
    public class PieContext : DbContext
    {
        public PieContext(DbContextOptions<PieContext> options) : base(options)
        {
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Cheese cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Seasonal pies" });

            //seed pies

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 1,
                Name = "Apple Pie",
                Price = 12.95M,
                ShortDescription = "Our famous apple pies!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                IsPieOfWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 2,
                Name = "Blueberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 3,
                Name = "Cheese Cake",
                Price = 18.95M,
                ShortDescription = "Plain cheese cake. Plain pleasure.",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 4,
                Name = "Cherry Pie",
                Price = 15.95M,
                ShortDescription = "A summer classic!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 5,
                Name = "Christmas Apple Pie",
                Price = 13.95M,
                ShortDescription = "Happy holidays with this pie!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 6,
                Name = "Cranberry Pie",
                Price = 17.95M,
                ShortDescription = "A Christmas favorite",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 7,
                Name = "Peach Pie",
                Price = 15.95M,
                ShortDescription = "Sweet as peach",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                InStock = false,
                IsPieOfWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 8,
                Name = "Pumpkin Pie",
                Price = 12.95M,
                ShortDescription = "Our Halloween favorite",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                InStock = true,
                IsPieOfWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                AllergyInformation = ""
            });


            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 9,
                Name = "Rhubarb Pie",
                Price = 15.95M,
                ShortDescription = "My God, so sweet!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                InStock = true,
                IsPieOfWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 10,
                Name = "Strawberry Pie",
                Price = 15.95M,
                ShortDescription = "Our delicious strawberry pie!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InStock = true,
                IsPieOfWeek = false,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                Id = 11,
                Name = "Strawberry Cheese Cake",
                Price = 18.95M,
                ShortDescription = "You'll love it!",
                Description =
                    "Icing carrot cake jelly-o cheesecake. ",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                InStock = false,
                IsPieOfWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });
        }
    }
}