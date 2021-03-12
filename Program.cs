using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace GymBookingSystem
{
    class Program
    {
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("se-SE");
        static void Main(string[] args)
        {
            Locale locale = new Locale();
            List<Costumer> lista = new List<Costumer>();

            locale.AddActivity(new Activity("Spinning", "Spinningklass 1 timme", new DateTime(2021, 03, 31, 17, 0, 0), new DateTime(2021, 03, 31, 18, 0, 0), 53422, 10, "Rum 2"));
            locale.AddActivity(new Activity("Cardio", "Cardioklass 1 timme", new DateTime(2021, 03, 31, 18, 0, 0), new DateTime(2021, 03, 31, 19, 0, 0), 58542, 10, "Rum 2"));
            locale.AddActivity(new Activity("Yoga", "Yogaklass 1 timme", new DateTime(2021, 03, 31, 18, 0, 0), new DateTime(2021, 03, 31, 19, 0, 0), 58542, 10, "Rum 1"));
            ViewSchedule(ref locale);

            do
            {
                //lista.Add(new Costumer(lista.Count(),"email", "password", "firstName", "lastName", 0735436315));

                
                Console.WriteLine("välkommen i bokningsappen");
                Console.WriteLine("1-registrera \n2-logga in");
                int svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    Console.WriteLine("Register User");
                    //skapa en account
                    Console.WriteLine("fn");
                    string fn = Console.ReadLine();
                    Console.WriteLine("ln");
                    string ln = Console.ReadLine();
                    Console.WriteLine("em");
                    string em = Console.ReadLine();
                    Console.WriteLine("pwd");
                    string pwd = Console.ReadLine();
                    Console.WriteLine("pho");
                    int pho = int.Parse(Console.ReadLine());

                    lista.Add(new Costumer(lista.Count(), em, pwd, fn, ln, pho));
                    Console.WriteLine(lista[lista.Count()-1].info());

                    Console.WriteLine("Succecful registration");


                    //adda den till listan här 

                }
                else if (svar == 2)
                {
                    Console.WriteLine("Change mail");
                    Console.WriteLine("Enter previus email: ");
                    String prevMail = Console.ReadLine();
                    Console.WriteLine("Enter password: ");
                    String pass = Console.ReadLine();
                    Console.WriteLine("Enter new email: ");
                    String newMail = Console.ReadLine();
                    if (lista[lista.Count() - 1].EditEmail(prevMail, pass, newMail))
                    {
                        Console.WriteLine("Mail successfully changed");
                    }
                    else
                    {
                        Console.WriteLine("Mail not successfully changed");
                    }
                }
                else if (svar == 3)
                {
                    Console.WriteLine(lista[lista.Count() - 1].Email);
                }



            } while (true);
        }

        static private void ViewSchedule(ref Locale locale)
        {
            // view full schedule
            for (int i = 0; i < locale.Activities.Count; i++)
            {
                Activity activity = locale.Activities[i];

                Console.WriteLine($"{i+1} {activity.StartDate.ToString("MM-dd HH:mm", culture)} - {activity.EndDate.ToString("HH:mm", culture)} - {activity.Title}, {activity.Locale}");
                Console.WriteLine("-------------------------------------------------------------------------");
            }
            Console.Write("Kolla detaljer om nr: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int value))
            {
                if (value > 0 && value < locale.Activities.Count + 1)
                {
                    Activity activity = locale.Activities[value - 1];
                    Console.Clear();
                    Console.WriteLine($"Title: {activity.Title}");
                    Console.WriteLine($"Beskrivning: {activity.Description}");
                    Console.WriteLine($"Instruktör: {activity.InstructorID}");
                    Console.WriteLine($"Dag: {activity.StartDate.ToString("MM-dd", culture)}");
                }
            }
        }
    }
}
