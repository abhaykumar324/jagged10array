using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class smallestnum
    {

        static void Main4()
        {
            int[][] arr =
            {
            new int[] { 10, 20 },
            new int[] { 30, 5, 15 },
            new int[] { 40, 25, 60 }
        };

            int min = arr[0][0];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < min)
                        min = arr[i][j];
                }
            }

            Console.WriteLine("Smallest = " + min);
        }
    }
}
