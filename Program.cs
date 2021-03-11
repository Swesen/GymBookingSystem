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
            List<Costumer> lista = new List<Costumer>();


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
    }
}
