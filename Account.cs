using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Account
    {
        public string Name { get; set; }
        public int Id { get;  }
        public bool InlogStatus { get; set; }
        public string Email { get; set; }
        public string Password { get;  }
        public int AccessLevel { get; }
        public Account()
        {

        }
        public string Info()
        {
            return "name: " + Name + "mail: " + Email + "password: " + Password;
        }
    }
}
