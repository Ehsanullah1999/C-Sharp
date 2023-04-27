using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i = 0;
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write(n + "\t");
                i++;
            } while (i <= n);
            Console.WriteLine();

            while (i <= n)
            {
                Console.Write(n + "\t");
                i++;
            }
            Console.WriteLine();
            for (i = 0; i <= n; i++)
            {
                Console.Write(n + "\t");
            }
            Console.ReadLine();
        }
    }
}
