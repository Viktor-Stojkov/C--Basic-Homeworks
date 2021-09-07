using System;

namespace Sum__Substract__Multiplication__Division_Method
{
    class Program
    {
        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            static int Substract(int num1, int num2)
            {
                return num1 - num2;
            }

            static int Multiplication(int num1, int num2)
            {
                return num1 * num2;
            }

            static int Division(int num1, int num2)
            {
                return num1 / num2;
            }


            while (true)
            {
                Console.WriteLine("Enter an operator ( + , - , * , / )");
                string forOperator = Console.ReadLine();
                if (forOperator != "+" && forOperator != "-" && forOperator != "*" && forOperator != "/")
                {
                    Console.WriteLine("Wrong input try again");
                    continue;
                }

                Console.WriteLine("Enter first number");
                bool forNumbers = int.TryParse(Console.ReadLine(), out int firstNumber);
                Console.WriteLine("Enter second number");
                forNumbers = int.TryParse(Console.ReadLine(), out int secondNumber);
                if (forOperator == "+") Console.WriteLine(Sum(firstNumber, secondNumber));
                if (forOperator == "-") Console.WriteLine(Substract(firstNumber, secondNumber));
                if (forOperator == "*") Console.WriteLine(Multiplication(firstNumber, secondNumber));
                if (forOperator == "/") Console.WriteLine(Division(firstNumber, secondNumber));

                Console.WriteLine("Would you like to try again, if not type NO");
                string choiceWhatNext = Console.ReadLine();
                if (choiceWhatNext == "NO")
                {
                    break;
                }
            }
        }
    }
}
