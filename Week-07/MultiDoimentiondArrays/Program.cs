using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDoimentiondArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[3, 4];
            int[,] mat2 = new int[4, 2] { { 2, 3 }, { 4, 5 }, { 1, 7 }, { 0, 9 } };
            int[,] mat3 = {{1, 2, 3 },{1, 2, 3},{1, 2, 3} };

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        Console.Write(mat2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Please enter numbers for row {0}: ", i);
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write("mat1 [{0},{1}] \t", i, j);
            //        mat1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Your nummbers are in mat1: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(mat1[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("Your numbers are in mat3: ");
            int counter = 0;
            foreach(int i in mat3)
            {
                Console.Write(i + "\t");
                counter++;
                if (counter == 3)
                {
                    counter = 0;
                    Console.WriteLine("\t");
                }
            }
            Console.WriteLine();

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(mat3[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
