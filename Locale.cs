using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Locale
    {
        public List<Activity> Activities { private set; get; }
        public List<Equipment> Equipment { private set; get; }

        public Locale()
        {
            Activities = new List<Activity>();
            Equipment = new List<Equipment>();
        }

        public void AddActivity(Activity activity)
        {
            Activities.Add(activity);
        }

        public void AddEquipment(Equipment equipment)
        {
            Equipment.Add(equipment);
        }
    }
}
