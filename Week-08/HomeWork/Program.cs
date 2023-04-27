using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static int Nag(int a, int b)
        {
            return a - b;
        }
        static int Nag1(int a, int b) => a - b;
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Mul1(int a, int b) => a * b;
        static double Div(double a, double b)
        {
            return a / b;
        }
        static double Div1(double a, double b) => a / b;
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nag of " + x + " and " + y + " is: " + Nag(x, y));
            Console.WriteLine("Nag of " + x + " and " + y + " is: " + Nag1(x, y));

            Console.WriteLine("Mul of " + x + " and " + y + " is: " + Mul(x, y));
            Console.WriteLine("Mul of " + x + " and " + y + " is: " + Mul1(x, y));

            Console.WriteLine("Div of " + x + " and " + y + " is: " + Div(x, y));
            Console.WriteLine("Div of " + x + " and " + y + " is: " + Div1(x, y));
            Console.ReadLine();
        }
    }
}
