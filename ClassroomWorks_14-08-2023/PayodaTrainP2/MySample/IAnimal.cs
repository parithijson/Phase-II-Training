using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal interface IAnimal
    {
        public void Sleep()
        {
            Console.WriteLine("Sleeping ");

        }

        public sealed void Eat()
        {
            Console.WriteLine("eatingggg");
        }
      
        public void Sound();

           

    }
}
