using System;

class Calculator
{
    static void Main()
    {
        int leftOperand = int.Parse(Console.ReadLine());
        char function = Console.ReadLine()[0];

        int rightOperand = int.Parse(Console.ReadLine());

        switch (function)
        {
            case '+':
                Console.WriteLine($"{leftOperand} + {rightOperand} = {leftOperand + rightOperand}");
                break;
            case '-':
                Console.WriteLine($"{leftOperand} - {rightOperand} = {leftOperand - rightOperand}");
                break;
            case '*':
                Console.WriteLine($"{leftOperand} * {rightOperand} = {leftOperand * rightOperand}");
                break;
            case '/':
                Console.WriteLine($"{leftOperand} / {rightOperand} = {leftOperand / rightOperand}");
                break;
            default:
                Console.WriteLine("Invalid");
                break;
        }
    }
}

