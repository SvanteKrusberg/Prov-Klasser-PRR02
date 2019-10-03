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

            Console.WriteLine("Hur många kunder?");
            int antalKunder = StringToInt(Console.ReadLine());
            
            Console.WriteLine("Vill du visa den bok du säljer?");
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

        //En metod som omvandlar ett användar input till en int och som sedan returnerar den int:en!
        static int StringToInt (string k)
        {
            int s;

            while (!int.TryParse(k, out s))
            {
                Console.WriteLine("Skriv in ett korrekt värde tack :)");
                k = Console.ReadLine();


            }

            return s;

        }

    }
}
