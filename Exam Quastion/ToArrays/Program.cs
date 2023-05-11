using System;

class Program
{
    static void Main(string[] args)
    {
        // خواندن رشته ورودی کاربر برای آرایه اول و تبدیل آن به آرایه عددی در C#
        Console.Write("Enter the first array (comma-separated): ");
        string input1 = Console.ReadLine();
        int[] arr1 = Array.ConvertAll(input1.Split(','), int.Parse);

        // خواندن رشته ورودی کاربر برای آرایه دوم و تبدیل آن به آرایه عددی در C#
        Console.Write("Enter the second array (comma-separated): ");
        string input2 = Console.ReadLine();
        int[] arr2 = Array.ConvertAll(input2.Split(','), int.Parse);

        // ادغام دو آرایه به صورت یک تکه در یک آرایه جدید و دانستن طول کل آرایه بعد از ادغام
        int[] mergedArray = new int[arr1.Length + arr2.Length];
        arr1.CopyTo(mergedArray, 0);
        arr2.CopyTo(mergedArray, arr1.Length);

        // چاپ تمامی عدد های قرار گرفته در آرایه جدید به همراه کاما
        Console.Write("Merged array: ");
        for (int i = 0; i < mergedArray.Length; i++)
        {
            Console.Write(mergedArray[i].ToString());
            if (i < mergedArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.ReadLine();
    }
}