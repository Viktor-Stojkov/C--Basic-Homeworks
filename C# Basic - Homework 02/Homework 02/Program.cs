using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered *{firstNumber}*");

            Console.WriteLine("Enter another number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered *{secondNumber}*");

            Console.WriteLine($"--> *{firstNumber}* and *{secondNumber}* <--");
            Console.ReadLine();
            if (firstNumber > secondNumber)
            {
                Console.Write($"Number *{firstNumber}* is largest");
                if (firstNumber % 2 == 0)
                {
                    Console.Write($" and number *{firstNumber}* is Even.");
                }
                else
                {
                    Console.Write($" and number *{firstNumber}* is Odd.");
                }
            }
            else if (firstNumber < secondNumber)
            {
                Console.Write($"Number *{secondNumber}* is largest");
                if (secondNumber % 2 == 0)
                {
                    Console.Write($" and number *{secondNumber}* is Even.");
                }
                else
                {
                    Console.Write($" and number *{secondNumber}* is Odd.");
                }
                Console.ReadLine();
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("Same number, try again.");
            }
            else
            {
                Console.WriteLine("In this case doesen't exist ELSE");
            }

            Console.ReadLine();
        }
    }
}
