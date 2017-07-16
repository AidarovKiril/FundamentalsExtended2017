using System;

class Transport
{
    static void Main()
    {
        int peoplesCount = int.Parse(Console.ReadLine());
        int carCapacity = 24;

        decimal courses = (int)Math.Ceiling((decimal)peoplesCount / carCapacity);

        Console.WriteLine(courses);

    }
}

