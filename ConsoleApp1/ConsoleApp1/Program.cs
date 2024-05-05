using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your first name: ");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your last name: ");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your birth year: ");
            int birthyear = Convert.ToInt32(Console.ReadLine());
            string fullName = firstName + " " + lastName;
            string phoneNum = "+94-123-456-789";

            fullName = fullName.ToLower();
            Console.WriteLine("\nYour Full name in lower case: " + fullName);
            fullName = fullName.ToUpper();
            Console.WriteLine("Your Full name in upper case: " + fullName);

            string username = fullName.Insert(0, "@");
            username = username.Replace(" ", "_");
            Console.WriteLine("Your username is : " + username + "_" + birthyear);

            phoneNum =  phoneNum.Replace("-" , "_");
            Console.WriteLine("Your phone number : " + phoneNum);

            string localphoneNum = phoneNum.Substring(4, 11);
            Console.WriteLine("Local phone number: " + localphoneNum);

            Console.WriteLine("Length of your name: " + fullName.Length);

            Console.ReadKey();
        }
    }
}
