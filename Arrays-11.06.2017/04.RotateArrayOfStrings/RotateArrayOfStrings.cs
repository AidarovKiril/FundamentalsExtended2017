using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            string[] resultArr = new string[arr.Length];

            for (int cnt = 0; cnt < arr.Length - 1; cnt++)
            {
                resultArr[cnt + 1] = arr[cnt];
            }
            resultArr[0] = arr[arr.Length - 1];
            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
