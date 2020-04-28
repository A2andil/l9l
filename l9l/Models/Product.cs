using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ShortDiscription { get; set; }

        public string LongDescription { get; set; }

        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int InStock { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int RateValue { get; set; }

        public double TotalRate { get; set; }

        public int NumberRaters { get; set; }

    }
}
