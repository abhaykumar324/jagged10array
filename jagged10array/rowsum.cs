using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class rowsum
    {
        static void Main2()
        {
            int[][] arr =
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };

            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;

                for (int j = 0; j < arr[i].Length; j++)
                    sum += arr[i][j];

                Console.WriteLine("Sum of row " + i + " = " + sum);
            }
        }
    }
}
