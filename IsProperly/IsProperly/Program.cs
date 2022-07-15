using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsProperly
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string sample = "((((a)))";
            string k = "(";
            string v = ")";
            int    b = 0;
            int a = 0;

            char[] characters = new char[sample.Length];
            for(int l = 0; l < sample.Length; l++)
            {
                _ = characters[l];
                Console.WriteLine(characters[l]);
            }

            for(int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == Convert.ToChar(k))
                {
                    a++;
                }
                else if (characters[i] == Convert.ToChar(v)) 
                {
                    b++;
                }
            }
            if (a == b)
            {   
                Console.WriteLine(Convert.ToString(b), Convert.ToString(a));
            }
            else Console.WriteLine("False");
        }
    }
}
