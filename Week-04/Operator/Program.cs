using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1 = 3, v2 = 5, v3 = 7, re;
            /*re = v1 ++ - v2 + -- v3 * v2 / v1;*/
            re = ((v1++ - v2) + (--v3 * (v2 / v1)));
            Console.WriteLine($" v1 = {v1} \n v2 = {v2} \n v3 = {v3} \n re = {re}");
            Console.ReadLine();
        }
    }
}
