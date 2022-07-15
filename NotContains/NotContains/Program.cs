using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("size of an array");
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            Console.WriteLine("Enter numbers for the array");
            for (int i = 0; i < k; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int TargetNumber = 0;
            var nearest = array.OrderBy(x => Math.Abs((long)x - TargetNumber)).First();
            if(nearest == 1)
            {
                Console.WriteLine("2");
            }
            else Console.WriteLine("1");
            Console.ReadKey();
        }
    }
}
