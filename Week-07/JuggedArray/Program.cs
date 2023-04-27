using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[][] trs;
            //string[][] Trs = new string[3][];
            /*tring[][] Trs = { new string[3] { "a", "k", "p" }, new string[1] { "5" }, new string[2] { "45", "sd" } };*/
            /*string[][] Trs = new string[3][] { new string[3], new string[5], new string[4] };*/
            int[][] a = new int[4][];
            a[0] = new int[4];
            a[1] = new int[3];
            a[2] = new int[2];
            a[3] = new int[1];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter the numbers: ");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
           /* for (int i = 0; i < 4; i++)
            {
                Console.Write($"a[{i}] = ");
                for (int j = 0; j < a[i].GetLength(0); j++)
                {
                    Console.Write(a[i][j] + "\t");
                }
                Console.WriteLine();
            }*/
            int k = 0;
            foreach (int[] x in a)
            {
                Console.Write($"a[{k}] = ");
                foreach (int y in x)
                {
                    Console.Write(y + "\t");
                }
                k++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
