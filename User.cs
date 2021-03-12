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
        public int PhoneNumber { get; private set; }

        public User(int id, string email, string password, string firstName, string lastName, int phoneNumer) : base(id, email, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumer;


        }
       public bool setFirstName(string email, string pass, string newname) 
        {
            if (email == this.Email)
            {
                if (pass == this.Password)
                {
                    this.FirstName = newname;
                    return true;
                }
            }
            return false; 
        }
       public bool setLastName(string email, string pass, string newname) 
        {
            if (email == this.Email)
            {
                if (pass == this.Password)
                {
                    this.LastName = newname;
                    return true;
                }
            }
            return false;
        }
       public bool setPhoneNumber(string email, string pass, int phoneNumber) 
        {
            if (email == this.Email)
            {
                if (pass == this.Password)
                {
                    this.PhoneNumber = phoneNumber;
                    return true;
                }
            }
            return false;
        }
    }
}
