using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayUsingBubbleSort
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        BubbleSort(arr);

        Console.WriteLine();
    }
    static void BubbleSort(int[] arr)
    {
        bool swapped = false;
        do
        {

            

            for (int arrIndex = 0; arrIndex < arr.Length; arrIndex++)
            {
                for (int index = 0; index < arr.Length - 1; index--)
                {
                    firstElement = arr[index];
                    secondElement = arr[index + 1];

                    if (firstElement > secondElement)
                    {
                        int tempElement = secondElement;
                        secondElement = firstElement;
                        firstElement = tempElement;
                    }
                }
            }
        } while (swapped);
    }
}

