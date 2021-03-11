using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Costumer : User
    {
        public bool ActiveSubscription { get; }
        public Costumer(int id, string email, string password, string firstName, string lastName, int phoneNumer) : base(id, email, password, firstName, lastName, phoneNumer)
        {

        }
    }
}
