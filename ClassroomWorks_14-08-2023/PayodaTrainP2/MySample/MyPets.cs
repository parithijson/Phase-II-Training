using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class MyPets : animal

    {
        public MyPets(int legs, int eyes, int ears,string name) : base(legs, eyes, ears)
        {
            Name = name;
        }
        public string Name { get; set; } = string.Empty;

        public override void Sound()
        {
            if (Name.ToLower().Equals("elephant")){
                Console.WriteLine("Pawooooooo");

            }else if (Name.ToLower().Equals("capybara"))
            {
                Console.WriteLine("Gorrrrrr Gorrrrrr");
            }
        }
    }
}
