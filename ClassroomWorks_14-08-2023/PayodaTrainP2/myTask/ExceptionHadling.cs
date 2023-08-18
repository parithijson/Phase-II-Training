using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask
{
    internal class ExceptionHadling
    {
        private int num1, num2, result, age;
        private int[] num3;

        public ExceptionHadling(int num1, int num2, int result, int age)
        {
            Num1 = num1;
            Num2 = num2;
            Num3 = num3;
            Result = result;
            Age = age;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Result { get => result; set => result = value; }

        public int Age { get => age; set => age = value; }
        public int[] Num3 { get => num3; set => num3 = value; }

        public int Add()
        {
            Result = num1 + num2;
            return Result;
        }
        public int Divide()
        {
            if (Num2 != 0)
            {
                Result = num1 / num2;

            }
            else
            {
                Result = 0;
                throw new ArithmeticException("DivideByZero!");
            }
            return Result;

        }

        public void CheckAge()
        {
            if (Age < 18)
            {
                throw new MyException();
            }
            else
            {
                Console.WriteLine("Ok!");
            }
        }
    }
}
