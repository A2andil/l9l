using System.Collections.Generic;

namespace l9l.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name  { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}