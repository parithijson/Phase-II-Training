using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
     class StaffDetails : College
    {
        int eno;
        private string? name, address;

        public StaffDetails(string? collegeName,string collegeAddress,int eno, string? name,string? address) :
            base(collegeName, collegeAddress)
        {
            Eno = eno;
            Name = name;
            Address = Address;
        }

        public int Eno { get => eno; set => eno = value; }
        public string? Name { get => Name1; set => Name1 = value; }
        public string? Name1 { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
       /* public sealed override void DisplayCollegDetails()
        {
            Console.WriteLine(CollegeName + "from class");
        }*/
    }
}
