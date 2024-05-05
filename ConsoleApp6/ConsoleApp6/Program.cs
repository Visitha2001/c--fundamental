using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("how many rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How many colums: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What symbol: ");
            string symbol = Console.ReadLine();

            Console.WriteLine("\n");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}