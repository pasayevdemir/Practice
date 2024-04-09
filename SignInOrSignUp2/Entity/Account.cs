using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInOrSignUp2.Entity
{
    public class Account
    {
        public User Profile { get; set; }
        public Account(User user)
        {
            Profile = user;
        }
    }
}
