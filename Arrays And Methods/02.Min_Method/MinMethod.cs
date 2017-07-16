using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class MinMethod
    {
        private static int PrintMinNumber(int firstNum, int secondNum)
        {
            if (firstNum < secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            PrintMinNumber(firstNum, secondNum);
            Console.WriteLine(Math.Min(PrintMinNumber(firstNum, secondNum), thirdNum));
        }
    }
}
