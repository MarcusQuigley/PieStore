using System;

namespace PieShopSite.Models
{
    public class Pie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfWeek { get; set; }
        public bool InStock { get; set; }
        public int Categoryid { get; set; }
        public Category Category { get; set; }

    }
}
