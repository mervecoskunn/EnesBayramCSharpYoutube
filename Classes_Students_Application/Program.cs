using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Students_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student1 = new Students(1, "Merve", "Coskun", 60, 50, 73, "TeknikSchool");
            Console.WriteLine("Welcome to the Students Application!!!");
            ShowMenu();
            while (true)
            {
                int select;
                int.TryParse(Console.ReadLine(), out select);
                switch (select) 
                {
                    case 1:
                        student1.StudentsInformation();
                        break;
                        case 2:
                       double studentsGrade = student1.StudentsGrade();
                        Console.WriteLine("Student grade is: "+ studentsGrade);
                        break;
                    case 3:
                        student1.SchoolName();
                        break;
                        case 4:
                        Console.WriteLine("Program is closing.");
                        break;

                    default:
                        Console.WriteLine("Please select between 1 to 4 from Menu!!!");
                        break;
                }


            }
        }
        static void ShowMenu()
        {

            Console.WriteLine("Please,select  the action you want to do!! ");
            Console.WriteLine("1-Show student information: ");
            Console.WriteLine("2-Show student grade: ");
            Console.WriteLine("3-Show student school name: ");
            Console.WriteLine("4-Exit: ");
        }

    }



}
   


