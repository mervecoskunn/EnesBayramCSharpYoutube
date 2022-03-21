using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to X Bank ATM!");
            Console.WriteLine("Please, choice the transaction you want to do.");
            Console.WriteLine("1- Show Balance" + "\n2- Withdraw" + "\n3- Deposit" + "\n4- Press Q for exit.");
            int choice;
            Console.Write("Choice: ");
            Int32.TryParse(Console.ReadLine(), out choice);
            int balance = 1000;

            if (choice == 1)
                Console.WriteLine("Balance: "+ balance);

            else if (choice==2)
            {
                Console.Write("Enter withdraw: ");
                int withdraw;
                int.TryParse(Console.ReadLine(), out withdraw);

                if (withdraw<=balance)
                    Console.WriteLine("Balance: " + (balance-withdraw));

                else if (withdraw > balance)
                            Console.WriteLine("Insufficient balance.");
            }

            else if (choice==3)
            {
                Console.Write("Enter deposit: ");
                int deposit;
                Int32.TryParse(Console.ReadLine(), out deposit);
                Console.WriteLine("Balance : "+ (balance+deposit));
            }
            else if (choice==4)
            {
                Console.WriteLine("Thank you for your visiting us.");
            }
            Console.ReadLine();

        }


    }

        
   

}

