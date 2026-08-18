using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class evenoddcount
    {
        static void Main5()
        {
            int[][] arr =
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8 }
        };

            int even = 0, odd = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] % 2 == 0)
                        even++;
                    else
                        odd++;
                }
            }

            Console.WriteLine("Even = " + even);
            Console.WriteLine("Odd = " + odd);
        }
    }
}
