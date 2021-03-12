using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Costumer> userList = new List<Costumer>();

            Console.WriteLine("Welcome");
            do
            {
                if (userList.Count() > 0)
                {
                    foreach (var user in userList)
                    {
                        if (user.InlogStatus)
                        {
                            LoggedinScreen(user);
                        }
                        else
                        {
                            LoginScreen(userList);
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
            Console.WriteLine("1 - Show schedule\n2 - User settings\n3 - Logout");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":

                    break;
                case "2":
                    Console.WriteLine("First name: {0} \nLast name: {1} \nEmail: {2} \nPhone number: {3}",user.FirstName, user.LastName, user.Email, user.PhoneNumber);
                    Console.WriteLine("1 - Change email \n2 - Change password\n3 - Change name \n4 - Change phone number\n5 - Back");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            ChangeEmail(user);
                            break;
                        case "2":

                            break;
                        case "3":

                            break;
                        case "4":

                            break;
                        default:
                            break;
                    }


                    break;
                case "3":

                    break;
            }
        }

        private static void LoginScreen(List<Costumer> userList)
        {
            
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
    }
}
