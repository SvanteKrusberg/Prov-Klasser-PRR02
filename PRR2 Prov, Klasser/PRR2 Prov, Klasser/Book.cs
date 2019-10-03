using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR2_Prov__Klasser
{
    class Book
    {
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        Random generator = new Random();

        public Book()
        {
            actualValue = generator.Next(1, 101);
            rarity = generator.Next(1, 6);

            if (IsCursed() == true){
                cursed = true;

            }
            else
            {
                cursed = false;

            }

        }

        public bool IsCursed()
        {
            int c = generator.Next(5);

            if (c == 4)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public string GetName()
        {


        }

        public string GetCategory()
        {



        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Rarity: " + rarity);
            
        }

    }
}
