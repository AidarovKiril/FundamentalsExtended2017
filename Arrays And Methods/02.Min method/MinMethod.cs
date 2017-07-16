using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_method
{
    class MinMethod
    {
        static void GetMin(int firstNum, int secondNum)
        {
            
            Console.WriteLine(Math.Min(firstNum, secondNum));
        }

        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            GetMin(firstNum, secondNum);
        }      
        

        
    }
}
