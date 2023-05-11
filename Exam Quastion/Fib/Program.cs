using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fib
{
    class Program
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());;

            Console.WriteLine("Fibonacci Sequence from 1 to {0}", n);
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", Fibonacci(i));
            }
            Console.ReadLine();
        }
    }
}
