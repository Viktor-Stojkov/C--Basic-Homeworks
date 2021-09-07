using System;

namespace Homework_RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput, secondInput;
            char operation;

            Console.Write("Input first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            secondInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            

            if (operation == '+')
                Console.WriteLine($"The result is: {firstInput + secondInput}");
            else if (operation == '-')
                Console.WriteLine($"The result is: {firstInput - secondInput}");
            else if (operation == '*')
                Console.WriteLine($"The result is: {firstInput * secondInput}");
            else if (operation == '/')
                Console.WriteLine($"The result is: {firstInput / secondInput}");
            else
                Console.WriteLine("Wrong Character");
        }
    }
}
