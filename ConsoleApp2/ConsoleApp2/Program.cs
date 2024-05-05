using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 100)
            {
                Console.WriteLine("You are too old to sign up");
            }
            else if (age >= 18)
            {
                Console.WriteLine("You are now signed up.");
            }
            else if(age <= 0)
            {
                Console.WriteLine("You haven't been born yet.");
            }
            else
            {
                Console.WriteLine("Are you sure you want to enter."); 
            }
            Console.ReadKey();
        }
    }
}
