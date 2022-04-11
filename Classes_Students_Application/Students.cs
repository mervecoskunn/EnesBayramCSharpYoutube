using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Students_Application
{
    public class Students // change public for accessibility
    {
       private string name;
       private string surname;
       private int studentsNumber;
       private string studentsSchoolName;
       private int exam1;
       private int exam2;
       private int finalexam;
        public Students(int _studentNumber, string _name, string _surname, int _exam1, int _exam2, int _final, string _schoolName)
        {
            studentsNumber = _studentNumber;
            name = _name;
            surname = _surname;
            studentsSchoolName = _schoolName;
            exam1 = _exam1;
            exam2 = _exam2;
            finalexam = _final;
        }

        public void StudentsInformation()
        {
            Console.WriteLine("Number of student: "+studentsNumber);
            Console.WriteLine("Name of student: "+name);
            Console.WriteLine("Surname of student: " + surname);
            Console.WriteLine("Exam 1:  " + exam1);
            Console.WriteLine("Exam 2: " + exam2);
            Console.WriteLine("Final exam:  " + finalexam);
            Console.WriteLine("School name: "+ studentsSchoolName);
        }
        public double StudentsGrade()
        {
           double studentsGrade= exam1 * 0.2 + exam2 * 0.2 + finalexam * 0.6;
            return studentsGrade;
        }
        public void SchoolName()
        {
            Console.WriteLine("School name: "+studentsSchoolName);
        }



    }
}
