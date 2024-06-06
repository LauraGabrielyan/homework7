using System.Collections.Generic;
using System.ComponentModel;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 7: Fibonacci Sequence
            // Write a program that reads an integer N from the user and prints
            // the first N numbers in the Fibonacci sequence.
            int a= 0;
            int b = 1;
            int c;
            Console.WriteLine("Please enter N");
            uint N = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci sequence");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < N; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
        }   }
    }
}
