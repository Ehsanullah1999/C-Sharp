using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branchin
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            char op;

            /*string req;
            Console.WriteLine("Enter your request: ");
            req = Console.ReadLine();*/


            Console.WriteLine("Enter first number: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an operator: ");
            op = Convert.ToChar(Console.ReadLine());

            //if (op == '+')
            //    Console.WriteLine(a + b);
            //else if (op == '-')
            //    Console.WriteLine(a - b);
            //else if (op == '*')
            //    Console.WriteLine(a * b);
            //else if (op == '/')
            //    Console.WriteLine(a / b);
            //else
            //    Console.WriteLine("Error");
            //Console.ReadLine();

            switch (op)
            {
                case '+':
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a - b);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(a * b);
                        break;
                    }
                case '/':
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Error");
                        }
                        Console.WriteLine(a / b);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Error");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
