﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Merve", "Derin", "Deniz", "Matu" };
            //for (int i  = 0;  i< names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}

            foreach (var name in names)
                Console.WriteLine(name);

            Console.ReadLine();
            


        }
    }
}
