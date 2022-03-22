using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Console.Write("Enter a number: ");
            double number;
            Double.TryParse(Console.ReadLine(), out number);
            for (int i = 0; i < number; i++)
            {
                total += i;

            }
            double avarage = 0;
            avarage = total / number;
            if (avarage>50)
                Console.WriteLine("Avarage bigger than 50. Avarage: " + avarage);
            else if (avarage<50)
            {
                Console.WriteLine("Avarage is smaller than 50. Avarage: "+ avarage);
            }
            Console.ReadLine();





        }
    }
}
