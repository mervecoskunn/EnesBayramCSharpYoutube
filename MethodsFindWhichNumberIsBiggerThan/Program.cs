using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFindWhichNumberIsBiggerThan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* entered two numbers from user
             * which number is bigger than other write it 
             */
            Console.WriteLine("Enter two numbers please.");
            Console.Write("Number 1: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("Number 2: ");
            int.TryParse(Console.ReadLine(),out int number2);
            WhichNumberIsBigger(number1,number2);
            Console.ReadLine();
        }
        static void WhichNumberIsBigger(int number1,int number2)
        {
            if (number1 > number2)
                Console.WriteLine("Number1 bigger than number2."+"\nNumber1: "+number1+"\nNumber2: "+number2);
            else if(number1==number2)
                Console.WriteLine("They are equals.");
            else
                Console.WriteLine("Number2 bigger than number1." + "\nNumber1: " + number1 + "\nNumber2: " + number2);


        }
    }
}
