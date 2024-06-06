using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace taskk10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 10: Sum of Digits

            //Write a program that reads an integer from the user and prints the sum of its digits.
            int number;
            int sum = 0;
            int  a;
            Console.WriteLine("Please enter  number ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                a = number % 10;
                sum = sum + a;
                number = number / 10;
            }
            Console.WriteLine( sum);
        }
    }
}
