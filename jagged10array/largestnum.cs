using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class largestnum
    {
        static void Main3()
        {
            int[][] arr =
            {
            new int[] { 10, 20 },
            new int[] { 30, 5, 15 },
            new int[] { 40, 25, 60 }
        };

            int max = arr[0][0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                        max = arr[i][j];
                }
            }

            Console.WriteLine("Largest = " + max);
        }
    }
}
