using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class RateProduct
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int AccountId { get; set; }

        public int RateValue { get; set; }

    }
}
