using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimentional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] a = new int[4][,];
            a[0] = new int[4,2];
            a[1] = new int[3,2];
            a[2] = new int[2,1];
            a[3] = new int[1,1];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the numbers: ");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    for (int h = 0; h < a[i].GetLength(1); h++)
                    {
                        a[i][j,h] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"a[{i}] = ");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    for (int h = 0; h < a[i].GetLength(1); h++)
                    {
                        Console.Write(a[i][j, h] + "\t");
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            /*int k = 0;
            foreach (int[,] x in a)
            {
                Console.Write($"a[{k}] = ");

                int Count_Clm = 0;
                foreach (int y in x)
                {
                    if (Count_Clm == x.GetLength(1))
                    {
                        Console.WriteLine();
                        Count_Clm = 0;
                    }
                    Console.Write("\t" + y + "\t");
                    Count_Clm++;
                }
                k++;
                Console.WriteLine();
                Console.WriteLine();
            }*/
            Console.ReadLine();
        }
    }
}