using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class userinput
    {
        static void Main1()
        {
            int[][] arr = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter size of row " + i + ": ");
                int n = int.Parse(Console.ReadLine());

                arr[i] = new int[n];

                for (int j = 0; j < n; j++)
                {
                    Console.Write("Enter element: ");
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nJagged Array:");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");

                Console.WriteLine();
            }
        }
    }
}

