using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhập vào số nguyên dương n: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Vui lòng nhập một số nguyên dương.");
            return;
        }

        Console.WriteLine($"Dãy Fibonacci với {n} số hạng là:");

        // In dãy Fibonacci
        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else if (n == 2)
        {
            Console.WriteLine("0 1");
        }
        else
        {
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");

            for (int i = 3; i <= n; i++)
            {
                int next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
            Console.WriteLine(); 
        }
    }
}
