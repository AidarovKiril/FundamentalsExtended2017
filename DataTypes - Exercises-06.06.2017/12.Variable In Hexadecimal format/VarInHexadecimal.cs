﻿using System;

class VarInHexadecimal
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(number, 16));
    }
}

