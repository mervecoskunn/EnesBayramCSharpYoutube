using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindANumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int totalNumber = 0;
            int[] numbers = { 1, 2, 2, 2, 5, 6,7,8,9, 10, 11, 12,13, 14 };
            Console.Write("Please enter a number:");
            int number;
            int.TryParse(Console.ReadLine(), out number);


            for (int i = 0; i < numbers.Length; i++)
            {
               
                if (number==numbers[i])
                    totalNumber++;
            }
            if (totalNumber==0)
                Console.WriteLine("It could not found.");
            else
            {
                Console.WriteLine(totalNumber+ " found.");
            }
            Console.ReadLine();
        }
    }
}
