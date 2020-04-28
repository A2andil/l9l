using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class Rate
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public int RateValue { get; set; }
    }
}
