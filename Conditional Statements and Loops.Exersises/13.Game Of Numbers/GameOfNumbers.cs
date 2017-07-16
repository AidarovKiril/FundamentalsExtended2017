using System;

class GameOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for (int i = m; i >= n; i--)
        {
            for (int j = m; j >= n; j--)
            {
                sum = i + j;
                counter++;
                if (sum == magicNumber)
                {
                    Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");

                    return;
                }
            }
        }


        Console.WriteLine("{0} combinations - neither equals {1} ", counter, magicNumber);
    }
}


