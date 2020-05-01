using l9l.Data.Api;
using l9l.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.ViewModels
{
    public class DetailsViewModel
    {
        public Product product { get; set; }

        public int RateValue { get; set; }

        public List<ApiComment> Comments { get; set; }
    }
}
