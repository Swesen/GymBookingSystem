using System;

namespace GymBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                User user = new User();

                Account NewUser = new Account();
                NewUser.Email = "1";
                NewUser.Password = "1";

                Console.WriteLine("välkommen i bokningsappen");
                Console.WriteLine("1-registrera \n2-logga in");
                int svar = int.Parse(Console.ReadLine());
                if (svar == 1)
                {
                    //skapa en account
                    Console.WriteLine("namn");
                    NewUser.Name = Console.ReadLine();

                    Console.WriteLine("mail");
                    NewUser.Email = Console.ReadLine();
                    user.email = NewUser.Email;
                    Console.WriteLine("password");
                    NewUser.Password = Console.ReadLine();
                    user.password = NewUser.Password;
                    Console.WriteLine(NewUser.Info());
                    Console.WriteLine("logga in NUUUUUU");
                    Console.WriteLine(user.Infox());





                    //adda den till listan här 

                }
                else if (svar == 2)
                {
                    Console.WriteLine("ange mail");
                    string mail = Console.ReadLine();
                    Console.WriteLine("password");
                    string password = Console.ReadLine();
                    //dubellkolla user
                    //foreach (var item in Users)
                    //{
                    //    if (item.Email.Equals(mail) && item.Password.Equals(password))
                    //    {
                    //        Console.WriteLine("välkommen");
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("ingen användare");
                    //    }
                    //}
                }



            } while (true);
        }
    }
}
