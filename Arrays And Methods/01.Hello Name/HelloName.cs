using System;
using System.Text;

class HelloName
{
    static void Main()
    {
        Hello();
    }
    static void Hello()
        {
            string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}!");

        }
}


