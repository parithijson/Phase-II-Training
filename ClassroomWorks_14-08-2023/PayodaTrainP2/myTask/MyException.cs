using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask
{
    public class MyException : Exception
    {
        public static List<string> Errors = new List<string>()
        {
            "UnderAge",

        };
        


    }
}
