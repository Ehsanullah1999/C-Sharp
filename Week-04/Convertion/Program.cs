using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            //int A;
            //double B = 34.89;
            //A = (int)B;
            //Console.WriteLine("B = {0}", B);
            //Console.ReadLine();

            //int A, B;
            //double C;
            //A = 1;
            //B = 3;
            //C = (double)A / B;
            //Console.WriteLine("C = {0}", C);
            //Console.ReadLine();

            /*double A = 6.500001;
            int B;
            B = Convert.ToInt32(A);
            Console.WriteLine("B = {0}", B);
            Console.WriteLine("=====================");*/

            //B = 0;
            //B = (int)A;
            //Console.WriteLine("B = {0}", B);

            /*B = 0;
            B = int.Parse(A);
            Console.WriteLine("B = {0}", B);*/

            int a = 12;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 4;

            int p = a + b * c - d / e;

            Console.WriteLine("p = {0}", p);

            Console.ReadLine();
        }
    }
}
