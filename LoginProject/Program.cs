using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordTry = 3;
            while (true)
            {
                Console.Write("Please enter your user name: ");
                string name =Console.ReadLine();
                Console.Write("Please enter your password:");
                string password =Console.ReadLine();


                if (name =="Merve" && password == "12345")
                {
                    Console.WriteLine("Congratulations! Login successful!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter correct name and password.");
                    if (passwordTry>0)
                    passwordTry -= 1;
                    if (passwordTry==0)
                {
                    Console.WriteLine("You tried 3 times with wrong name or password.");
                        break;
                }
                }

               
            }
            Console.ReadLine();
        }
    }
}
