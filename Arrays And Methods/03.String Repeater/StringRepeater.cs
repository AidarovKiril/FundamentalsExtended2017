using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StringRepeater
{
    public static string RepeatString(string str, int count)
    {
        string forRepetation = string.Empty;

        for (int i = 1; i <= count; i++)
        {
            forRepetation += str;
        }

        return forRepetation;
    }

    static void Main()
    {        
        string str = Console.ReadLine();
        int count = int.Parse(Console.ReadLine());
        string result = RepeatString(str, count);
        Console.WriteLine(result);
    }
}

