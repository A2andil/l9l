using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace l9l.Data.ViewModels
{
    public class MembershipUnit
    {
        public string Key { get; set; }

        public string Value { get; set; }
    }

    public class RegisterViewModel
    {
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Phone { get; set; }

        public string Membership { get; set; }

        public List<MembershipUnit> Types = new List<MembershipUnit>
        {
            new MembershipUnit
            {
                Key = "User",
                Value = "User"
            },
            new MembershipUnit
            {
                Key = "Designer",
                Value = "Designer"
            }
        };
    }
}
