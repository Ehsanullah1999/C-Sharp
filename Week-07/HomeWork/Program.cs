using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double Determinant(double[,] matrix)*/
            {
                int[,] matrix = new int[2, 2] { { 2, 3 }, { 4, 5 } };
                // اندازه ماتریس را بررسی کنید.
                int rows = matrix.GetLength(0);
                int cols = matrix.GetLength(1);
                if (rows != cols)
                {
                    throw new ArgumentException("Matrix is not square.");
                }

                if (rows == 1)
                {
                    // اگر اندازه ماتریس یک است، دیترمینانت برابر عنصر وحید آن است.
                    Console.Write(matrix[0, 0]);
                }

                double det = 0;
                double sign = 1;
                for (int i = 0; i < rows; i++)
                {
                    Console.WriteLine(i);
                    // یک زیرماتریس n-1*n-1 ایجاد کنید.
                    double[,] subMatrix = new double[rows - 1, cols - 1];
                    for (int j = 1; j < rows; j++)
                    {
                        Console.WriteLine(j);
                        for (int k = 0; k < cols; k++)
                        {
                            Console.WriteLine(k);
                            if (k < i)
                            {
                                // کپی کردن ستون‌های اول ماتریس اصلی به زیرماتریس.
                                subMatrix[j - 1, k] = matrix[j, k];
                            }
                            else if (k > i)
                            {
                                // کپی کردن ستون‌های دوم به بعد ماتریس اصلی به زیرماتریس.
                                subMatrix[j - 1, k - 1] = matrix[j, k];
                            }
                        }
                    }

                    // یک معادله بازگشتی برای محاسبه دیترمینانت سابماتریس فعلی ایجاد کنید.
                    /*det += sign * matrix[0, i] * Convert.ToDouble(subMatrix);*/

                    // تغییر نامزدی برای جایگزین کردن دیترمینانت سابماتریس بعدی.
                    /*sign *= -1;*/
                }

                // دیترمینانت را بازگردانید.
                /*return det;*/
                Console.ReadLine();
            }
        }
    }
}
