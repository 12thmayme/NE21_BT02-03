using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào số nguyên n: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương hợp lệ.");
            return;
        }

        long sum = CalculateSum(n);

        Console.WriteLine($"Tổng S = 1 + 2^2 + 3^3 + ... + {n}^{n} là: {sum}");
    }

    static long CalculateSum(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (long)Math.Pow(i, i);  
        }
        return sum;
    }
}
