using l9l.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }

        public List<Category> Categories { get; set; }

        public string Header { get; set; }
    }
}
