using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace tassk4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 4: Reverse a String

            //Write a program that reads a string from the user and prints the reversed string.
            Console.WriteLine("Please enter string");
            string input = Console.ReadLine();
            for (int i = input.Length-1; i >=0; i--) 
            {
                char ch = input[i];
                Console.Write(ch);
               
            }
            Console.WriteLine();
            //or while loop
            Console.WriteLine("Please enter string");
            string input1 = Console.ReadLine();
            int length;
            length = input1.Length - 1;
           

            while (length >= 0)
            {
                 char ch1 = input1[length];
                length--;
                Console.Write(ch1);
            }
            


        }
    }
}
