using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool ConfirmedPhone { get; set; }

        public string Password { get; set; }

        public bool ConfirmedPassword { get; set; }

        public string AccountType { get; set; }
    }
}
