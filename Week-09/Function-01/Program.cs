using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_01
{
    class Program
    {
        static void Volume (int h, int l, int w)
        {
            Console.WriteLine("Volume is = " + h * l * w);
        }

        static int Area (int h, int l, int w)
        {
            int area = ((l * h) * 2) + ((l * w) * 2) + ((h * w) * 2); 
            return area;
        }

        static int Peremeter (int h, int l, int w)
        {

            return 0;
        }
        static void Main(string[] args)
        {
            int hight, length, Width;
            Console.WriteLine("***Enter the dimantions****");
            Console.Write("Hight = ");
            hight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Length = ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Wifth = ");
            Width = Convert.ToInt32(Console.ReadLine());

            Volume(hight, length, Width);
            Console.ReadLine();
        }
    }
}
