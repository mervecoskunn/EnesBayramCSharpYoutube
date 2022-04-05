using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSquareTheEnteredNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if entered numbers square bigger than 25; write this numbers square is bigger than 25 or not.
             */
            int NewResult = squareNumber(3);
            if (NewResult>25)
                Console.WriteLine("This numbers´square is bigger than 25.");
            else
                Console.WriteLine("This numbers´square is smaller than 25.");
            Console.ReadLine();

        }
        static int squareNumber(int number)
        {
            int result = number * number;
            return result;

        }
    }
}
