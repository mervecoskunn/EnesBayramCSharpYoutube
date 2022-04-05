using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFindEnteredNumberIsOddOrEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if entered number is odd; write this number is odd 
             * if entered number is even; write this number is even number.
             */
            Console.Write("Enter a number: ");
           int.TryParse(Console.ReadLine(), out var number);
            IsOddOrEven(number);
            Console.ReadLine();


        }
        static void IsOddOrEven(int number)
        {
            if (number%2== 0)
                Console.WriteLine("This number is  an even number.");
            else
                Console.WriteLine("This number is an odd number.");
           

        } 
        
    }
}
