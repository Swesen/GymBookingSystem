using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Instructor: User
    {
        public string Role { get; }
        public Instructor(int id, string email, string password, string firstName, string lastName, int phoneNumer, string role) : base(id, email, password, firstName, lastName, phoneNumer)
        {
            this.Role = role;
        }
    }
}
