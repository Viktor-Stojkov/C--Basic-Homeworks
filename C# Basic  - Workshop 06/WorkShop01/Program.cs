using System;

namespace WorkShop01
{
    class Program
    {
        static void Main(string[] args)
        {
            string theFollowingString = "The whole group of G2 loves C#.They find learning this language fun and easy!";
            Console.WriteLine($"From this text we need text after Dash (.) \n*{theFollowingString}*");
            string findStringAfterDash = ".";
            string weFound = theFollowingString.Substring(theFollowingString.IndexOf(findStringAfterDash) + findStringAfterDash.Length);
            Console.WriteLine(weFound);
            Console.ReadLine();
        }
    }
}
