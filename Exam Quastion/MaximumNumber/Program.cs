using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of one-digit integers separated by spaces:");
            string input = Console.ReadLine();

            // رشته ورودی را به آرایه ای از اعداد صحیح تبدیل میکند
            string[] strArray = input.Split(' ');
            int[] numbers = new int[strArray.Length];

            // هر رشته در آرایه را به یک عدد صحیح تبدیل کنید
            for (int i = 0; i < strArray.Length; i++)
            {
                numbers[i] = int.Parse(strArray[i]);
            }

            // با استفاده از الگوریتم Bubble Sort آرایه را به ترتیب صعودی مرتب کنید
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            // آرایه مرتب شده را به ترتیب نزولی چاپ کنید
            Console.WriteLine("The largest number from the list of digits is: ");
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}