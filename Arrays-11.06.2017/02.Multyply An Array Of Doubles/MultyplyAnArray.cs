using System;

class MultyplyAnArray
{
    static void Main(string[] args)
    {
        var stringArr = Console.ReadLine().Split();
        var arr = new double[stringArr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(stringArr[i]);

        }
    }
}

