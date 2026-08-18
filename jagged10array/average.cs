using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class average
    {
        static void Main7()
        {
            int[][] arr =
            {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70 }
        };

            int sum = 0, count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                    count++;
                }
            }

            double average = (double)sum / count;

            Console.WriteLine("Average = " + average);
        }
    }
}
