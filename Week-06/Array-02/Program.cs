using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 4, 6, 8, 10, };
            int j = 0;
            /*for(int i = 0; i < 4; i++)
            {
                a[i] = a[i] + 2;
            }*/
            foreach (int i in a)
            {
                j = i + 2;
            }
            /*for (int i = 0; i < 4; i++)
            {
                Console.Write(a[i] + "\t");
            }*/
            foreach(int i in a)
            {
                Console.Write(i +"\t");
            }
            Console.ReadLine();
        }
    }
}