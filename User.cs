using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class User : Account
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long PhoneNumber { get; private set; }

        public User(int id, string email, string password, string firstName, string lastName, int phoneNumer) : base(id, email, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumer;


        }

        public User() : base(-1, "", "")
        {
        }

        public bool setFirstName(string pass, string newname) 
        {
            
            if (pass == this.Password)
            {
                this.FirstName = newname;
                return true;
            }
            return false; 
        }
       public bool setLastName(string pass, string newname) 
        {
            
            if (pass == this.Password)
            {
                this.LastName = newname;
                return true;
            }
            return false;
        }
       public bool setPhoneNumber(string pass, long phoneNumber) 
        {
            
            if (pass == this.Password)
            {
                this.PhoneNumber = phoneNumber;
                return true;
            }
            
            return false;
        }
    }
}
