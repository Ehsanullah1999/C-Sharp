using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 0, 0, 0, 0, 0, 0 },{ 1, 0, 0, 0, 0, 0}, { 0, 1, 0, 0, 0, 0}, { 1, 0, 1, 0, 0, 0 }, { 0, 0, 0, 1, 0, 0}, { 0, 0, 1, 0, 1, 0} };
            int[,] Smatrix = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        Console.Write("Enter the space: ");
                        Smatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        Smatrix[i, j] = 0;
                    }
                }
            }
                Console.WriteLine();
                for (int i = 0; i < 6; i++)
                {
                    for (int j  = 0; j <= i; j++)
                    {
                        Console.Write(Smatrix[i, j] + "   ");
                    }
                Console.WriteLine();
                }
            Console.ReadLine();
        }
    }
}
