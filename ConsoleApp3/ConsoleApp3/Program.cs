using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a week day : ");
            string day =  Console.ReadLine();
            day = day.ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("It's Monday.");
                    break;
                case "tuesday":
                    Console.WriteLine("It's Tuesday.");
                    break;
                case "wednesday":
                    Console.WriteLine("It's Wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("It's Thursday.");
                    break;
                case "firday":
                    Console.WriteLine("It's Firday.");
                    break;
                default: 
                    Console.WriteLine("Please enter a week day..!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
