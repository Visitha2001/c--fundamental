﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            while (name == "")
            {
                Console.WriteLine("What is your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}
