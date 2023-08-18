using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class TeachingStaff : StaffDetails
    {
        private string? department;
        private double basicSalary;
        private readonly int _da, _hra, _cca, _pf;

        public TeachingStaff(string? collegeName, string collegeAddress,int eno, string? name, string? address,string? department, double basicSalary,int da,int hra,int cca, int pf) :
            base(collegeName, collegeAddress, eno,name,address)
        {
            this.department = department;
            this.basicSalary = basicSalary;
            _da = da;
            _hra = hra; 
            _cca = cca; 
            _pf = pf;   

        }

        public string? Department { get => department; set => department = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public float CalculateSalary()
        {
            float netSalary = (float)(BasicSalary +
                (BasicSalary * (Da / 100))+
                (BasicSalary * (Hra/100))+
                (BasicSalary * (Cca/100))-
                (BasicSalary * (Pf/100))
                );
            return netSalary;
        }
       /* public sealed override void DisplayCollegDetails()
        {
            Console.WriteLine(CollegeName + "from class");
        }*/
    }
}
