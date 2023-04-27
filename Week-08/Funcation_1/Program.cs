using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcation_1
{
    class Program
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Sum1(int a, int b) => a + b;

        static void Main(string[] args)
        {
            int x, y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of the two numbers is: " + Sum(x, y));
            Console.WriteLine("Sum of the two numbers is: " + Sum1(x, y));
            Console.ReadLine();
        }
    }
}
