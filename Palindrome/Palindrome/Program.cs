using System;

namespace Palindrome // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool checkPalindrome(string inputString)
        {
            char[] c = inputString.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(inputString);
        }
        public static void Main()
        {   string a = Console.ReadLine();
            Console.WriteLine(checkPalindrome(a));
          

        }
    }
}