using System.Collections.Generic;
using System.ComponentModel;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2: Sum of First N Natural Numbers

            //Write a program that reads an integer N from the user and prints the sum of
            //the first N natural numbers.
            Console.WriteLine("Please enter N natural number");
            uint N=Convert.ToUInt32(Console.ReadLine());
            int sum=0;
            for (int i=0; i<=N; i++)
            {
                  sum+=i;
            }
            Console.WriteLine("Sum of the first {0} natural numbers = {1}" , N, sum);
        }
    }
}
