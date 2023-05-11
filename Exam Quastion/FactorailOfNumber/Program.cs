using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorailOfNumber
{
    class Program
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The factorial of {n} is: {Factorial(n)}");
            Console.ReadLine();
        }
    }
}
