using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class User: Account
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public int PhoneNumber { get;  }

        public User()
        {
           

        }
       public bool setFirstName() { return false; }
       public bool setLastName() { return false; }
       public bool setPhoneNumber() { return false; }
    }
}
