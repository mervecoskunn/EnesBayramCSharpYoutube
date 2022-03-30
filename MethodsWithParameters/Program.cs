using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            addition(5,10);
            multiplication(5,10);
            nameAndSurname("Merve", "Coskun");
            Console.ReadLine();
        }
        static void addition(int number1, int number2)
        {
            int additionTotal=number1+number2;
            Console.WriteLine("Addition= "+additionTotal);
        }
        static void multiplication(int number1,int number2)
        {
            int multiplicationTotal = number1 * number2;
            Console.WriteLine("Multiplication= " + multiplicationTotal);
        }
        static void nameAndSurname(string name, string surname)
        {
            Console.WriteLine("Name and Surname: " + name + " " + surname);
        }
    }
}
