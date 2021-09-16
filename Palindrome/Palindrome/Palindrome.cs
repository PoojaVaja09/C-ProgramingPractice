using System;

namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            string inputStr;
            string reverseStr = string.Empty;

            Console.WriteLine("Enter string:");
            inputStr = Console.ReadLine();

            for(int i=inputStr.Length-1;i>=0;i--)
            {
                char c = inputStr[i];
                reverseStr = reverseStr + c ;
            }
            Console.WriteLine(reverseStr);

            if (inputStr == reverseStr)
            {
                Console.WriteLine("Input string is palindrome");
            }
            else
            {
                Console.WriteLine("Input string is not palindrome");
            }

            Console.ReadLine();
                
        }
    }
}
