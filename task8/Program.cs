using System;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 8: Prime Numbers

            //Write a program that reads two integers(start and end) from the user
            //prints all prime numbers in that range.
            Console.WriteLine("Enter the start number:");
            int start =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end number:");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers");

            for (int i = start; i <= end; i++)
            {
                 int ctr = 0;  
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;  
           
                    }
                }

                if (ctr == 0 && i != 1)
                {
                    Console.WriteLine(i);  
                }
            }
            

        }
    }
}
