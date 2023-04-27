using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBenfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Blance, Blance_Goal, Bank_Benfite;
            int Months_width = 0;
            Console.WriteLine("Enter your blance: ");
            Blance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Goal: ");
            Blance_Goal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your Bank Benfite: ");
            Bank_Benfite = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            while(Blance <= Blance_Goal)
            {
                Blance = (Blance * (Bank_Benfite / 100)) + Blance;
                Months_width++;
                Console.WriteLine("\f Your Blance after " + Months_width + "th Months is: " + Blance);
            }

            //Console.WriteLine("Your Blance after one month: ");

            //Blance_Goal = (Blance * (Bank_Benfite / 100)) + Blance;
            //Console.WriteLine("\t" + Blance_Goal);

            Console.WriteLine("\n");
            Console.WriteLine("\v Number of mouth that you should wait is: "+ Months_width);
            Console.ReadLine();
        }
    }
}
