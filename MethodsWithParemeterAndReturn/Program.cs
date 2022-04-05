using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsWithParemeterAndReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string newNameAndSurname = NameAndSurname("Merve","Coskun");
            Console.WriteLine(newNameAndSurname);
            Console.ReadLine();
        }
        static string NameAndSurname(string name, string surname)
        {
              return name +" "+surname;
        }
    }
}
