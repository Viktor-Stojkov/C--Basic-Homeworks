using System;

namespace Homework_FindStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInput, secondInput;

            Console.Write("Enter first number: ");
            firstInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            secondInput = Convert.ToInt32(Console.ReadLine());
            if (firstInput % 2 == 0 && secondInput % 2 == 0)
            {
                int sum = firstInput + secondInput;
                Console.WriteLine($"The input's are Even, their sum is {sum}");
            }
            else if (firstInput % 2 == 0 || secondInput % 2 == 0)
            {
                int difference = firstInput - secondInput;
                Console.WriteLine($"One of the input is Odd, their difference is {difference}");
            }
            else
            {
                int multy = firstInput * secondInput;
                Console.WriteLine($"Both of ther are Odd, their sum is {multy}");
            }
            Console.ReadLine();
        }
    }
}
