using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class JA
    {
        public void disp1d()
        {

            int[] numbers = new int[4];
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;

            foreach (var item in numbers)
            {
                Console.Write("{0}", item);
            }

            /*
                        numbers[0] =  { 1, 2, 3, 4 };
                        numbers[1] =  { 11, 34, 67 };
                        numbers[2] =  { 89, 23 };
                        numbers[3] =  { 0, 45, 78, 53, 99 };*/

            /*Console.WriteLine(numbers[1][2]);
            Console.WriteLine(numbers[3][2]);*/


            /*  for (int i = 0; i < numbers.Length; i++)
              {
                  Console.Write("Row({0}): ", i);
                  for (int j = 0; j < numbers[i].Length; j++)
                  {
                      Console.Write("{0} ", numbers[i][j]);
                  }
                  Console.WriteLine();
              }*/
        }
        /*  public void dispmd()
          {
              int sizee = Convert.ToInt32(Console.Read());
              int[][,] jagged_arr1 = new int[sizee][,]
  {
      new int[, ] { {1, 3}, {5, 7} },
      new int[, ] { {0, 2}, {4, 6}, {8, 10} },
      new int[, ] { {7, 8}, {3, 1}, {0, 6} },
      new int[, ] { {11, 22}, {99, 88}, {0, 9} }
  };*/


        /*
        // Jagged array with 4 2-D arrays
        int[][,] numbers = new int[4][,] 
        {
            new int[, ] {{1, 3}, {5, 7}},
            new int[, ] {{0, 2}, {4, 6}, {8, 10}},
            new int[, ] {{7, 8}, {3, 1}, {0, 6}},
            new int[, ] {{11, 22}, {99, 88}, {0, 9}}
        };

        for (int i = 0; i < numbers.Length; i++)
        {
            int x = 0;
            for (int j = 0; j < numbers[i].GetLength(x); 
                j++)
            {
                for (int k = 0; k < numbers[j].Rank; k++)
                {
                    Console.Write(numbers[i][j, k] + " ");
                }
                Console.WriteLine();
            }
            x++;
            Console.WriteLine();
        }
    */
    }
}