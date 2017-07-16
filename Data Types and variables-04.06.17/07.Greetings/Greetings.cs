using System;

class Greetings
{
    static void Main()
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
    }
}

