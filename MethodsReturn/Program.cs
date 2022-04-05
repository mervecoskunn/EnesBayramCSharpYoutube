using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Return wıth parameter
             * 
             */
            int newResult = addition(6,7);
            if (newResult > 10)
                Console.WriteLine("New result is bigger than result. "+"\nNew Result is : " + newResult);

            else
                Console.WriteLine("New result is smaller than result."+"\nNew Result is : " + newResult);
            Console.ReadLine();
           
        }
        static int addition(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
            

        }
    }
}
