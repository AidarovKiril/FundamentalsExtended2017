using System;

class ASCIIString
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = string.Empty;
        for (int count = 0; count < n; count++)
        {
            int symbolNumber = int.Parse(Console.ReadLine());
            word += (char)symbolNumber;
        }
        Console.WriteLine(word);
    }
}

