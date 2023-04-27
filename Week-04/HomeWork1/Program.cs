using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            int credit,per;
            Console.WriteLine("Enter your cridet: ");
            credit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your percentage: ");
            per = Convert.ToInt32(Console.ReadLine());

            if ((credit >= 17) && (credit <= 21) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 1st semister and your percentage is not bad you have a chance to compensate.");
            }
            else if ((credit >= 17) && (credit <= 21) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 1st semister and your percentage is good.");
            }
            else if ((credit >= 17) && (credit <= 21) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 1st semister and your percentage is great.");
            }
            else if ((credit >= 17) && (credit <= 21) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 1st semister and your percentage is the best.");
            }
            else if ((credit >= 22) && (credit <= 38) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 2nd semister and your percentage is not bad you have a chance to compensate.");
            }
            else if ((credit >= 22) && (credit <= 38) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 2nd semister and your percentage is good.");
            }
            else if ((credit >= 22) && (credit <= 38) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 2nd semister and your percentage is great.");
            }
            else if ((credit >= 22) && (credit <= 38) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 2nd semister and your percentage is the best.");
            }
            else if ((credit >= 39) && (credit <= 55) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 3rd semister and your percentage is not bad you have a chance to compensate.");
            }
            else if ((credit >= 39) && (credit <= 55) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 3rd semister and your percentage is good.");
            }
            else if ((credit >= 39) && (credit <= 55) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 3rd semister and your percentage is great.");
            }
            else if ((credit >= 39) && (credit <= 55) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 3rd semister and your percentage is the best.");
            }
            else if ((credit >= 56) && (credit <= 72) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 4th semister and your percentage is not bad you have a chance to compensate.");
            }
            else if ((credit >= 56) && (credit <= 72) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 4th semister and your percentage is good.");
            }
            else if ((credit >= 56) && (credit <= 72) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 4th semister and your percentage is great.");
            }
            else if ((credit >= 56) && (credit <= 72) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 4th semister and your percentage is the best.");
            }
            else if ((credit >= 73) && (credit <= 95) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 5th semister and your percentage is not bad hurry you should work harder.");
            }
            else if ((credit >= 73) && (credit <= 95) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 5th semister and your percentage is not bad you have a chance to compensate.");
            }
            else if ((credit >= 73) && (credit <= 95) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 5th semister and your percentage is great.");
            }
            else if ((credit >= 73) && (credit <= 95) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 5th semister and your percentage is the best.");
            }
            else if ((credit >= 96) && (credit <= 115) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 6th semister and your percentage is not bad hurry you should work harder " +
                    "you don't have any chance to compensate.");
            }
            else if ((credit >= 96) && (credit <= 115) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 6th semister and your percentage is good.");
            }
            else if ((credit >= 96) && (credit <= 115) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 6th semister and your percentage is great.");
            }
            else if ((credit >= 96) && (credit <= 115) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 6th semister and your percentage is the best.");
            }
            else if ((credit >= 116) && (credit <= 132) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 7th semister and your percentage is not bad you don't have any time to " +
                    "compensate.");
            }
            else if ((credit >= 116) && (credit <= 132) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 7th semister and your percentage is good.");
            }
            else if ((credit >= 116) && (credit <= 132) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 7th semister and your percentage is great.");
            }
            else if ((credit >= 116) && (credit <= 132) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 7th semister and your percentage is the best.");
            }
            else if ((credit >= 133) && (credit <= 149) && (per >= 55) && (per <= 75))
            {
                Console.WriteLine("Your in 8th semister and your percentage is not bad.");
            }
            else if ((credit >= 133) && (credit <= 149) && (per >= 75) && (per <= 85))
            {
                Console.WriteLine("Your in 8th semister and your percentage is good.");
            }
            else if ((credit >= 133) && (credit <= 149) && (per >= 85) && (per <= 95))
            {
                Console.WriteLine("Your in 8th semister and your percentage is great.");
            }
            else if ((credit >= 113) && (credit <= 149) && (per >= 95) && (per <= 100))
            {
                Console.WriteLine("Your in 8th semister and it is impossible maybe you conflict.");
            }
            else
            {
                Console.WriteLine("This cridet is out of range please a cridet in range.");
            }
            Console.ReadLine();
        }
    }
}
