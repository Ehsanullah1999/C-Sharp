using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] Score;
            //int[] Score1 = { 5, 6, 7, 8, 9 };
            //int[] Score2 = new int[4] { 3, 4, 5, 6 };
            //int[] Score3 = new int[6];
            int[] Score = new int[3];
            String[] Lessons = new string[3];
            int Sum = 0;
            double Avg;

            for (int i = 0; i < Lessons.Length; i++)
            {
                Console.WriteLine("Enter Lesson's name: ");
                Lessons[i] = Console.ReadLine();
                Console.WriteLine("Enter Lesson's Score: ");
                Score[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Lessons.Length; i++)
            {
                Sum = Sum + Score[i];
            }
            Avg = (double)Sum / Lessons.Length;

            Console.WriteLine("  Lessons  |  Score  |  Category |  State");
            Console.WriteLine("-----------|---------|-----------|-----------");

            for (int i = 0; i < Lessons.Length; i++)
            {
                Console.Write($"{Lessons[i]}      |   {Score[i]}    |");
                switch (Lessons[i])
                {
                    case string t when t.StartsWith("p"):
                        Console.Write("PROGRAMING |");
                        break;
                    case string t when t.StartsWith("m"):
                        Console.Write("    MATH   |");
                        break;
                    case string t when t.StartsWith("i"):
                        Console.Write("  GENRAL   |");
                        break;
                }
                if (Score[i] < 45)
                {
                    Console.Write(" FALIED  \n");
                }
                else if ((Score[i] >= 45) && (Score[i] <= 55))
                {
                    Console.Write(" TRY AGAIN \n");
                }
                else
                    Console.Write(" PASSED \n");
            }

            Console.WriteLine("---------------------|----------------------");
            Console.WriteLine($"        Averge       |       {Avg}        ");

            Console.ReadLine();
        }
    }
}