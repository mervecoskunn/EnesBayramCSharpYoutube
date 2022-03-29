using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysInputFromUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter "+ i+ ". index name : ");
                string inputName = Convert.ToString(Console.ReadLine());


            }
            Console.ReadLine();
        }
    }
}
