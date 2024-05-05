using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "BMW", "Benz", "Lambogini", "Mustang" };
            cars[0] = "GTR-34";
            foreach (string CAR  in cars)
            {
                Console.WriteLine(CAR);
            }
            Console.ReadKey();
        }
    }
}
