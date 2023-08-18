using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    abstract class animal
    {
        private int eyes,ears,legs;

        public animal(int legs, int eyes, int ears)
        {
            Legs = legs;
            Eyes = eyes;
            Ears = ears;
        }

        public int Eyes { get => eyes; set => eyes = value; }
        public int Ears { get => ears; set => ears = value; }
        public int Legs { get => legs; set => legs = value; }

        public static void Sleep()
        {
            Console.WriteLine("Sleeping Zzzzz ");
        }
        public static void Eat()
        {
            Console.WriteLine("Eating yummmmmm");
        }
        public  void AboutMe()
        {
            Console.WriteLine($"I;ve {Eyes} eyes {Ears} ears and {Legs} legs");
        }

        public abstract void Sound();
    }
}







