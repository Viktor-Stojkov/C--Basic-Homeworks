using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int enterNumber;

            Console.WriteLine("Please enter one number from 1 to 3.");
            string input = Console.ReadLine();
            bool numberSucces = int.TryParse(input, out enterNumber);
            switch (enterNumber)
            {
                case 1:
                    Console.WriteLine("You got a car");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike");
                    break;
                default:
                    Console.WriteLine("Wrong input, please enter number from 1 to 3 only");
                    break;
            }
            //if (enterNumber == 1)
            //{
            //    Console.WriteLine("You got a car");
            //}
            //else if(enterNumber == 2)
            //{
            //    Console.WriteLine("You got a new plane");
            //}
            //else if(enterNumber == 3)
            //{
            //    Console.WriteLine("You got a new bike");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input, please enter number from 1 to 3 only");
            //}
        }
    }
}
