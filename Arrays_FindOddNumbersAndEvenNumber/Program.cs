using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_FindOddNumbersAndEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Take 10 inputs from user and  find how many odd numbers or even numbers
             * Find also total of even numbers and odds numbers
             * which one is bigger than other total and write to screen which one is bigger than.
             */
            int number;
            int[] numbers = new int[10];

            int evenNumbersTotal = 0;
            int oddsNumbersTotal = 0;
            int countOfEvenNumbers = 0;
            int countOfOddNumbers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i+". index enter number: ");
                int.TryParse(Console.ReadLine(), out number);
                numbers[i]=number; 

            }
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j]%2==0)
                {
                    countOfEvenNumbers++;
                    evenNumbersTotal+= numbers[j];
                }
                else
                {
                    countOfOddNumbers++;
                    oddsNumbersTotal+=numbers[j];
                }
            }
            if (evenNumbersTotal > oddsNumbersTotal)
                Console.WriteLine("Even numbers total is bigger than odd numbers total.");

            else 
                Console.WriteLine("Odd numbers total is bigger than even numbers total.");

          


            Console.WriteLine("'''''''''''''''''''''''");
            Console.WriteLine("Even numbers total: "+evenNumbersTotal);
            Console.WriteLine("Even numbers count: "+countOfEvenNumbers);
            Console.WriteLine("Odd numbers total: "+ oddsNumbersTotal);
            Console.WriteLine("Odd numbers count: "+ countOfOddNumbers);

           

            Console.ReadLine();

            
        }
    }
}
