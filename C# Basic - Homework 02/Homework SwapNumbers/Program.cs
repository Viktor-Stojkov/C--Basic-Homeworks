using System;

namespace Homework_SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput, secondInput;

            Console.Write("Enter first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            secondInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Before Swap: {firstInput} and {secondInput}");

            Console.WriteLine("Press Enter to see after Swap the difference");
            Console.ReadLine();

            (firstInput, secondInput) = (secondInput, firstInput);
            Console.WriteLine($"After Swap: {firstInput} and {secondInput}");
        }
    }
}
