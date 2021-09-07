using System;
using System.Linq;

namespace Reverse_Order_From_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Please enter couple character's");
                string reverseInput = Console.ReadLine();
                foreach (var reverseOrder in reverseInput)
                {
                    Console.WriteLine(reverseOrder);
                }
                reverseInput.Reverse();

                Console.WriteLine("Would you like to try again, if doesn't like type NO or no. ");
                string tryAgain = Console.ReadLine();
                if (tryAgain == "NO" || tryAgain == "no")
                {
                    break;
                }
            }
        }
    }
}
