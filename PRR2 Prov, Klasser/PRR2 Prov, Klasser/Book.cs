using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR2_Prov__Klasser
{
    class Book
    {

        //Här skapar jag alla de viktiga variablerna som kommer användas
        public int price;
        private string name;
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        Random generator = new Random();

        /*Denna konstruktor körs när klassen skapas, detta gör att den skapar alla värden
        utan att vi behöver kalla den metoden varje gång vi skapar en klass */

        public Book()
        {
            actualValue = generator.Next(1, 101);
            rarity = generator.Next(1, 6);

            //Om metoden IsCursed returnar true så blir bool:en cursed = true
            if (IsCursed() == true){
                cursed = true;

            }
            else
            {
                cursed = false;

            }

            //Här har jag skapat enkla listor med namn och genrer av böcker
            List<string> bookList = new List<string>() { "Liv", "Död", "Lugn", "Fågel" };
            List<string> categoryList = new List<string>() { "Romantik", "Komedi", "Skräck" };
            //Här plockar jag ett av namnen/genrena för varje bok slumpmässigt
            name = bookList[generator.Next(4)];
            category = categoryList[generator.Next(3)];
            //Här blir price den int som Evaluate metoden returnerar
            price = Evaluate();

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
            return name;


        }

        public string GetCategory()
        {
            return category;


        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Category: " + category);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Rarity: " + rarity);
            
        }

        public int Evaluate()
        {

            int p;
            p = actualValue * rarity;

            p = p * generator.Next(51, 151);

            p = p / 100;

            return p;


        }

    }
}
