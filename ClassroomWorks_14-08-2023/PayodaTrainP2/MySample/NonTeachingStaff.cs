using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class NonTeachingStaff : StaffDetails
    {
        private double basicSalary;
        private readonly float _da, _hra, _cca, _pf;

        public NonTeachingStaff(string? collegeName, string collegeAddress, int eno, string? name, string? address, double basicSalary, int da, int hra, int cca, int pf) :
            base(collegeName, collegeAddress, eno, name, address)
        {
            _cca = cca;
            _da = da;
            _hra = hra;
            _pf = pf;
            BasicSalary = basicSalary;
        }

        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public float Da => _da;

        public float Hra => _hra;

        public float Cca => _cca;

        public float Pf => _pf;
        public float CalculateSalary()
        {
            float netSalary = (float)(BasicSalary +
                (BasicSalary * (Da / 100)) +
                (BasicSalary * (Hra / 100)) +
                (BasicSalary * (Cca / 100)) -
                (BasicSalary * (Pf / 100))
                );
            return netSalary;
        }
    }
 
}
