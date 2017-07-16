using System;

class FromTerabytesToBites
{
    static void Main()
    {
        decimal terabyte = decimal.Parse(Console.ReadLine());
        decimal bite = terabyte * 1024 * 1024 * 1024 * 1024 * 8;
        Console.WriteLine(Math.Round(bite));
    }
}

