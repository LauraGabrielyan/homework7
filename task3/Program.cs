using System.ComponentModel;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 3: Multiplication Table

            //Write a program that prints the multiplication table for numbers 1 to 10.

          
            for (int i = 1; i <= 10; i++)
            {
                
                Console.Write($"Multiplication table for {i}:\n");
 
                for (int j = 1; j <= 10; j++)
                {    
                    Console.WriteLine("{0} * {1} = {2}" , i,j, i*j);
                }

               
                //Console.WriteLine();
            }
        }
    }
}
