using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        decimal product = 0m;

        for (int i = 0; i < n; i++)
        {
            product *= decimal.Parse(Console.ReadLine());
        }
        Console.WriteLine(product);
    }
}

