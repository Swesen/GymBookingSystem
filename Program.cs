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
        static bool accountLoggedin = false;
        static CultureInfo culture = CultureInfo.CreateSpecificCulture("se-SE");
        static void Main(string[] args)
        {
            List<Costumer> userList = new List<Costumer>();
            Locale locale = new Locale();
            List<Costumer> lista = new List<Costumer>();

            // example schedule data
            locale.AddActivity(new Activity("Spinning", "Spinningklass 1 timme", new DateTime(2021, 03, 31, 17, 0, 0), new DateTime(2021, 03, 31, 18, 0, 0), 53422, 10, "Rum 2"));
            locale.AddActivity(new Activity("Cardio", "Cardioklass 1 timme", new DateTime(2021, 03, 31, 18, 0, 0), new DateTime(2021, 03, 31, 19, 0, 0), 58542, 10, "Rum 2"));
            locale.AddActivity(new Activity("Yoga", "Yogaklass 1 timme", new DateTime(2021, 03, 31, 18, 0, 0), new DateTime(2021, 03, 31, 19, 0, 0), 58542, 10, "Rum 1"));
            ViewSchedule(ref locale, false);

            Console.WriteLine("Welcome");
            do
            {
                Console.Clear();
                if (userList.Count() > 0)
                {

                    if (!accountLoggedin)
                    {

                        LoginScreen(userList);
                    }
                    foreach (var user in userList)
                    {
                        if (user.InlogStatus)
                        {
                            accountLoggedin = true;
                            LoggedinScreen(user);
                            break;
                        }
                    }
                }
                else
                {
                    LoginScreen(userList);
                }
                
            } while (true);
        }

        private static void LoggedinScreen(User user)
        {
            Console.Clear();
            Console.WriteLine("1 - Show schedule\n2 - User settings\n3 - Logout");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("First name: {0} \nLast name: {1} \nEmail: {2} \nPhone number: {3}",user.FirstName, user.LastName, user.Email, user.PhoneNumber);
                    Console.WriteLine("1 - Change email \n2 - Change password\n3 - Change first name \n4- Change last name \n5 - Change phone number\n6 - Back");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            ChangeEmail(user);
                            break;
                        case "2":
                            ChangePassword(user);
                            break;
                        case "3":
                            ChangeFirstName(user);
                            break;
                        case "4":
                            ChangeLastName(user);
                            break;
                        case "5":
                            ChangePhoneNumber(user);
                            break;
                        default:
                            break;
                    }


                    break;
                case "3":
                    accountLoggedin = false;
                    user.LogOut();
                    break;
            }
        }

        private static void ChangePhoneNumber(User user)
        {
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter new phone number: ");
            long newPhoneNumber = long.Parse(Console.ReadLine());
            if (user.setPhoneNumber(pass, newPhoneNumber))
            {
                Console.WriteLine("Phone number successfully changed");
            }
            else
            {
                Console.WriteLine("Phone number not successfully changed");
            }
        }

        private static void ChangeFirstName(User user)
        {
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter new first name: ");
            string newFirstName = Console.ReadLine();
            if (user.setFirstName(pass, newFirstName))
            {
                Console.WriteLine("First name successfully changed");
            }
            else
            {
                Console.WriteLine("First name not successfully changed");
            }
        }
        private static void ChangeLastName(User user)
        {
            Console.WriteLine("Enter password: ");
            string pass = Console.ReadLine();
            Console.WriteLine("Enter new last name: ");
            string newLastName = Console.ReadLine();
            if (user.setLastName(pass, newLastName))
            {
                Console.WriteLine("Mail successfully changed");
            }
            else
            {
                Console.WriteLine("Mail not successfully changed");
            }
        }
        private static void LoginScreen(List<Costumer> userList)
        {
            Console.Clear();
            Console.WriteLine("1 - Register \n2 - Log in");
            int svar = int.Parse(Console.ReadLine());

            if (svar == 1)
            {
                Registration(userList);
                Console.WriteLine(userList[userList.Count() - 1].FirstName);
            }
            else if (svar == 2)
            {
                LoginUser(userList);
            }
        }

        private static bool LoginUser(List<Costumer> lista)
        {
            Console.Clear();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter Password: ");
            string passwrd = Console.ReadLine();

            foreach (var user in lista)
            {
                if (user.Email == email)
                {
                    if (user.Password == passwrd)
                    {
                        user.LogIn();
                        Console.WriteLine("Successfull login");
                        return true;
                    }
                }
            }
            Console.WriteLine("Email and/or password does not match to an exsisting account");
            return false;
        }

        private static void ChangeEmail(User user)
        {
            Console.Clear();
            Console.WriteLine("Change mail");
            Console.WriteLine("Enter previus email: ");
            String prevMail = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            String pass = Console.ReadLine();
            Console.WriteLine("Enter new email: ");
            String newMail = Console.ReadLine();
            if (user.EditEmail(prevMail, pass, newMail))
            {
                Console.WriteLine("Mail successfully changed");
            }
            else
            {
                Console.WriteLine("Mail not successfully changed");
            }
        }
        private static void ChangePassword(User user)
        {
            Console.WriteLine("Change pass");
            Console.WriteLine("Enter email: ");
            String mail = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            String pass = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            String newPass = Console.ReadLine();
            if (user.EditPassword(mail, pass, newPass))
            {
                Console.WriteLine("Password successfully changed");
            }
            else
            {
                Console.WriteLine("Password not successfully changed");
            }
        }

        /*
         * Method to register a user
         * Does not return anything (void)
         */
        private static void Registration(List<Costumer> lista)
        {
            Console.WriteLine("Register User");
            Console.WriteLine("Enter first name: ");
            string fn = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string ln = Console.ReadLine();
            Console.WriteLine("Enter email: ");
            string em = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string pwd = Console.ReadLine();
            Console.WriteLine("Confirm password: ");
            string repwd = Console.ReadLine();
            Console.WriteLine("Enter phone number: ");
            int pho = int.Parse(Console.ReadLine());

            if (pwd == repwd)
            {
                lista.Add(new Costumer(lista.Count(), em, pwd, fn, ln, pho));
                Console.WriteLine("Registraion successfull");
            }
            else
            {
                Console.WriteLine("Password does not match, Unsuccessfull registration");
            }
        }

        static private void ViewSchedule(ref Locale locale, bool loggedIn)
        {
            string lineBreak = "------------------------------------------------------------------------";
            bool stillViewing = true;
            do
            {

                Console.Clear();
                Console.WriteLine($"nr | Starttid - Sluttid  |   Namn ,  Lokal  |");
                Console.WriteLine(lineBreak);
                // view full schedule
                for (int i = 0; i < locale.Activities.Count; i++)
                {
                    Activity activity = locale.Activities[i];

                    Console.WriteLine($"{i + 1}. | {activity.StartDate.ToString("MM-dd HH:mm", culture)} - {activity.EndDate.ToString("HH:mm", culture)} | {activity.Title}, {activity.Locale}");
                    Console.WriteLine(lineBreak);
                }
                Console.Write("Kolla detaljer om nr: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    if (value > 0 && value < locale.Activities.Count + 1)
                    {
                        Activity activity = locale.Activities[value - 1];
                        Console.Clear();
                        Console.WriteLine(lineBreak);
                        Console.WriteLine($"Title: {activity.Title}");
                        Console.WriteLine($"Beskrivning: {activity.Description}");
                        Console.WriteLine($"Instruktör: {activity.InstructorID}");
                        Console.WriteLine($"Lokal: {activity.Locale}");
                        Console.WriteLine($"Dag: {activity.StartDate.ToString("MM-dd", culture)}");
                        Console.WriteLine($"Tid: {activity.StartDate.ToString("HH:mm", culture)} - {activity.EndDate.ToString("HH:mm", culture)}");
                        Console.WriteLine($"Deltagare: {activity.Participants.Count} Max antal: {activity.MaxParticipant}");
                        Console.WriteLine(lineBreak);
                    }
                }

                Console.Write("Vill du fortsätta att titta på schemat? J/N: ");
                input = Console.ReadLine();

                if (input != "J")
                {
                    stillViewing = false;
                }
            } while (stillViewing);
        }
    }
}
