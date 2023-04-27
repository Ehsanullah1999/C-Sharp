using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace1
{
    class c1
    {
        public void F1()
        {
            Console.WriteLine("Your in \"NameSpace 1\" and Class \"C1\" and Function \"F1\"");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NameSpace1.c1 obj1 = new NameSpace1.c1();
            NameSpace2.c1 obj2 = new NameSpace2.c1();
            obj1.F1();
            obj2.F1();
            Console.ReadLine();
            //string ans;
            //Console.WriteLine("Enter your Answer");
            //ans = Console.ReadLine();
            //NameSpace2.A.print(ans);
            //Console.ReadLine();
        }
    }
}
//using static System.Console; <==== This code is For Writing codes without Consol
namespace NameSpace2
{
    class c1
    {
        public void F1()
        {
            Console.WriteLine("Your in \"NameSpace 2\" and Class \"C1\" and Function \"F1\"");
        }
    }
    //class A
    //{
    //    static public void print(string x)
    //    {
    //        Console.WriteLine(x);
    //    }
    //}
}
