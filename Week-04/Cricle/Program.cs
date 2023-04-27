using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Pi = 3.14;
            Console.WriteLine("Please Enter the Raduis of Cricle: ");
            double raduis = 0.0;
            raduis = Convert.ToInt32(Console.ReadLine());

            double area = Pi * raduis * raduis;
            double S = Pi * raduis * 2;

            Console.WriteLine("\a \t \t \t \f area = {0} \v", area);
            Console.WriteLine("\a \t========================******========================");
            Console.WriteLine("\a \t \t \t \f Peimeter = {0} \v", S);

            Console.ReadLine();
        }
    }
}
