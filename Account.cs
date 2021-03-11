using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Account
    {
        public int Id { get;  }
        public bool InlogStatus { get; private set; } = false;
        public string Email { get; private set; }
        public string Password { get; private set; }
        public int AccessLevel { get; }
        public Account(int id, string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }
        public bool EditEmail(string prevEmail, string pass, string newEmail)
        {
            if (prevEmail == Email)
            {
                if (pass == Password)
                {
                    this.Email = newEmail;
                    return true;
                }
            }
            return false;
        }

        public bool EditPassword(string email, string pass, string newpass)
        {
            if (email == Email)
            {
                if (pass == Password)
                {
                    this.Password = newpass;
                    return true;
                }
            }
            return false;
        }

        public void LogIn()
        {
            InlogStatus = true;
            Console.WriteLine("inlog");
        }

        public void LogOut()
        {
            InlogStatus = false;
            Console.WriteLine("logout");
        }

        public string info()
        {
            return "email: " + Email + "id:" + Id+ "password: "+ Password;
        }
        
    }
}
