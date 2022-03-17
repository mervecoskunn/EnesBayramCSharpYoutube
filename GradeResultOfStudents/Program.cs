using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeResultOfStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentPoint = 65;
            int minimumSuccessfulPoint = 60;
            if (studentPoint<minimumSuccessfulPoint)
            
                Console.WriteLine("Unsuccessful");
            else
                Console.WriteLine("Successful");
            Console.ReadLine();
        }
    }
}
