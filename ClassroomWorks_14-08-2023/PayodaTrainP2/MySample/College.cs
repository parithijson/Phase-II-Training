using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class College
    {
        private string? collegeName, collegeAddress;

        public College(string? collegeName, string? collegeAddress)
        {
            CollegeName = collegeName;
            CollegeAddress = collegeAddress;
        }

        public string? CollegeName { get => collegeName; set => collegeName = value; }
        public string? CollegeAddress { get => collegeAddress; set => collegeAddress = value; }

       /* public static abstract virtual sealed override void DisplayCollegDetails()
        {
            Console.WriteLine(CollegeName);
        }*/
    }
}
