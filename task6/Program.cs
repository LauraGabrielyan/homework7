using System.ComponentModel;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 6: Find Factorial

            //Write a program that reads an integer N from the user and prints the factorial of N.
            Console.WriteLine("Please enter N natural number");
            uint N = Convert.ToUInt32(Console.ReadLine());
            int factorial = 1;
            for (int i=1;i<=N; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("The factorial of N = " +  factorial);
        }
    }
}
