using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class sumofallelements
    {
        static void Main()
        {
            int[][] arr =
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

            int sum = 0;

            foreach (int[] row in arr)
            {
                foreach (int value in row)
                {
                    sum += value;
                }
            }

            Console.WriteLine("Total Sum = " + sum);
        }
    }
}
