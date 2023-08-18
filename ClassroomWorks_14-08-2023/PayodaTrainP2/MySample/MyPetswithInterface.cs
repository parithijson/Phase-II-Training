using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class MyPetswithInterface : IAnimal
    {
        private int eyes, ears, legs;
        private string? name = string.Empty;

        public MyPetswithInterface(int eyes, int ears, int legs, string? name)
        {
            Eyes = eyes;
            Ears = ears;
            Legs = legs;
            Name = name;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }
        public string? Name { get => name; set => name = value; }

        public void AboutMe()
        {
            Console.WriteLine($"I;ve {Eyes} eyes {Ears} ears and {Legs} legs");
        }

        public void Eat()
        {
            
             Console.WriteLine("Eating yummmmmm");
            
        }

        public void Sleep()
        {
            
            Console.WriteLine("Sleeping ");

        }

        public void Sound() {
            if (Name.ToLower().Equals("elephant"))
            {
                Console.WriteLine("Pawooooooo");

            }
            else if (Name.ToLower().Equals("capybara"))
            {
                Console.WriteLine("Gorrrrrr Gorrrrrr");
            }
        }
       
    }
}
