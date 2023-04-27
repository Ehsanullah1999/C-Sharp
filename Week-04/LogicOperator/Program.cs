using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool a;
            //a = Convert.ToBoolean(0);
            //Console.WriteLine(a);
            int Age;
            Console.WriteLine("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            //bool ans = ((Age < 30) && (Age > 20));
            Console.WriteLine("You are " + ((Age < 30) && (Age > 20)) + " Young");
            //Console.WriteLine("You are " + ans + " Young");
            Console.WriteLine("You are " + ((Age > 30) && (Age < 50)) + " Midel man");
            Console.WriteLine("You are" + ((Age == 30) || (Age <= 20) || (Age >= 50)) + " Comment");
            Console.ReadLine();
        }
    }
}
