using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachForArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Merve", "Derin", "Deniz", "Matu" };
            //for (int i = 0; i <names.Length ; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            // double[] numbers ={1.10,2.10};
            // char[] characters ={'a','b','d'};

        }
    }
}
