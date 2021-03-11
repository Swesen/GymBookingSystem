using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class User : Account
    {
        public string FirstName { get;  }
        public string LastName { get;  }
        public int PhoneNumber { get;  }

        public User(int id, string email, string password, string firstName, string lastName, int phoneNumer) : base(id, email, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumer;


        }
       public bool setFirstName() { return false; }
       public bool setLastName() { return false; }
       public bool setPhoneNumber() { return false; }
    }
}
