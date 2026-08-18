using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged10array
{
    internal class elementsearch
    {
       
            static void Main6()
            {
                int[][] arr =
                {
            new int[] { 10, 20 },
            new int[] { 30, 40, 50 },
            new int[] { 60, 70 }
        };

                Console.Write("Enter value to search: ");
                int x = int.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        if (arr[i][j] == x)
                        {
                            Console.WriteLine("Found at row " + i + ", column " + j);
                            found = true;
                        }
                    }
                }

                if (!found)
                    Console.WriteLine("Element not found.");
            }
        }
}
