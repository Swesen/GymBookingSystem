using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Equipment
    {
        public string Type { private set; get; }
        public int Id {private set; get; }
        public string Status { private set; get; }
        public bool Broken { private set; get; }

        public Equipment(string type, int id)
        {
            Type = type;
            Id = id;
            Status = "";
            Broken = false;
        }

        public  void SetAsBroken(string status)
        {
            Broken = true;
            Status = status;
        }

        public void Repaired(string status)
        {
            Broken = false;
            Status = status;
        }
    }
}
