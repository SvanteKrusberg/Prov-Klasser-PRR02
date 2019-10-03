using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR2_Prov__Klasser
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Visa bok?");
            Console.WriteLine("A: Ja");
            Console.WriteLine("B: Nej");
            string input = Console.ReadLine().ToLower();

            if(input == "a")
            {

                Book b1 = new Book();

                b1.PrintInfo();
                

            }
            else if (input == "b")
            {
                Console.WriteLine("Jaha okej då stängs spelet av, klicka enter :)"
                    );

            }
            //Har inte tid att hantera jobbiga användare
            else
            {
                Console.WriteLine("Synd att du skrev ett felaktigt värde, roligt för dig men nu e spelet slut då :)");

            }

            Console.ReadLine();

        }
    }
}
