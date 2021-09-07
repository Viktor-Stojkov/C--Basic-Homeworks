using System;

namespace Find_Sentence_As_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("For String press 1 and for Integer press 2: ");
                string inputForString = Console.ReadLine();
                if (inputForString == "1")
                {
                    Console.WriteLine("Please Enter you'r full name: ");
                    string fullName = Console.ReadLine();
                    Console.WriteLine($"Nice to meet you {fullName}, my name is Viktor.");
                }
                else if (inputForString == "2")
                {
                    Console.WriteLine("Please enter you'r age: ");
                    int yourAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"You have {yourAge} year's.");

                }
                else
                {
                    Console.WriteLine("Wrong input try again");
                    continue;
                }

                Console.WriteLine("Would you like to try again ?    - Type NO or no for exit.");
                string tryAgain = Console.ReadLine();
                if (tryAgain == "NO" || tryAgain == "no" || tryAgain == "exit")
                {
                    break;
                }
            }
        }
    }
}
