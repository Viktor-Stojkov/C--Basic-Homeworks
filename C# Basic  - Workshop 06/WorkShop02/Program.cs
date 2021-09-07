using System;

namespace WorkShop02
{
    class Program
    {
        static void Main(string[] args)
        {

            

            while (true)
            {

                Console.WriteLine("Please enter a number: ");
                bool enterNumber = double.TryParse(Console.ReadLine(), out double number);
                NumberStats(number);

                if (!enterNumber)
                {
                    Console.WriteLine("Wrong input, please enter 1 or 2");
                    continue;
                }
                Console.WriteLine("\nHit two time Enter to try again, if you like to break press EXIT. ");
                string tryAgain = Console.ReadLine();
                if (tryAgain == "exit" || tryAgain == "EXIT")
                {
                    break;
                }
                Console.ReadLine();
            }
        }
        static void NumberStats(double number)
        {
            Console.WriteLine($"\nStats for number: {number}");
            if (number > 0)
            {
                //bool positiveNumber = number > 0;
                Console.WriteLine($"\nPositive");
            }
            else
            {
                //bool negativeNumber = number < -0;
                Console.WriteLine($"\nNegative");
            }

            if (number % 1 == 0)
            {
                Console.WriteLine("\nInteger");
            }
            else
            {
                Console.WriteLine("\nDecimal");
            }

            if (number % 2 == 0)
            {
                Console.WriteLine($"\nEven ");
            }
            else
            {
                Console.WriteLine("\nOdd");
            }
        }
    }
}
