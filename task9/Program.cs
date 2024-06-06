using System.ComponentModel;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 9: Pattern Printing

            // Write a program that prints a pyramid pattern of stars with N levels.

            Console.Write("Enter the number  N of levels for the pyramid: ");
            int Nlevels = Convert.ToInt32(Console.ReadLine());

            

            for (int i = 1; i <= Nlevels; i++)
            {
               
                for (int j = 1; j <= Nlevels - i; j++)
                {
                    Console.Write(" ");
                }

               
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                
               Console.WriteLine();
       
            }   
        }
    }
}
