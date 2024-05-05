using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void main(string[] args)
        {
            Console.WriteLine("Please enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are now signed up.");
            }
            else
            {
                Console.WriteLine("Are you sure you want to enter.");
            }

            Console.ReadKey();
        }
    }
}
