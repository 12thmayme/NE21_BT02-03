using System;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write($"{i} x {j} = {i * j}\t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
            }
        }
    }
}