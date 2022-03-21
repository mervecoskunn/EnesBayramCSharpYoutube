using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                BMI < 18.5 Underweight
                18.5 ≤ BMI < 25.0 Normal
                25.0 ≤ BMI < 30.0 Overweight
                30.0 ≤ BMI Obese
             */
            Console.Write("Enter your weight in kg :");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Enter height in meters: ");
            double height;
            Double.TryParse(Console.ReadLine(), out height);

            double bmi = weight / (height * height);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
            if (bmi < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Overweight");
            }
            else if(bmi>=30)
            {
                Console.WriteLine("Obese");
            }
            Console.ReadLine();

        }
    }
}
