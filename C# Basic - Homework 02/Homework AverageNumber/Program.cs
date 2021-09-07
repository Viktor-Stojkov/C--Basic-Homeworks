using System;

namespace Homework_AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInput, secondInput, thirdInput, fourInput;

            Console.Write("Enter first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            thirdInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter four number: ");
            fourInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The average of {firstInput}, {secondInput}, {thirdInput}, {fourInput} " +
                $"is: ^{(firstInput + secondInput + thirdInput + fourInput) / 4}^");
        }
    }
}
