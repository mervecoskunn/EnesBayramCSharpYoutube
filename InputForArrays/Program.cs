using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputForArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            { 
                Console.Write("Please enter "+ i + ". index of numbers: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("-------------------------------------------------------------------------------");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            Console.ReadLine();
        }
    }
}
