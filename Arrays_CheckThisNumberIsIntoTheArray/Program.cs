using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_CheckThisNumberIsIntoTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // check entered users number is into the array.
            //If they have same numbers please write how much find it 
            //and if you coul not find same numbers please write to screen there is no same number.
            int[] numbers = {10,20,20,20,30,40,50,60,70,80,90,40,50,60,50,60,30,70,80,80,10 };
            int userNumber;
            int count = 0;
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out userNumber);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (userNumber==numbers[i])
                    count++;
            }
            if (count==0)
                Console.WriteLine("Same number  not found.");
            else
            {
                Console.WriteLine("Same number found ");
                Console.WriteLine("Count: "+count);
            }
            Console.ReadLine();

        }
    }
}
