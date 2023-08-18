using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class StudentDetails : College
    {
           private int rno;
           private string? name,address;
           private int age;

        public StudentDetails(string? collegeName, string? collegeAddress, int rno, string? name, string? address, int age):
            base(collegeName, collegeAddress)
        {
            this.Rno = rno;
            this.Name = name;
            this.Address = address;
            this.Age = age;
        }

        public int Rno { get => rno; set => rno = value; }
        public string? Name { get => name; set => name = value; }
        public string? Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }


    }
  
}
