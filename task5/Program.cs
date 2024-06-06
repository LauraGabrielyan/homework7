using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 5: Count Vowels in a String
            //Write a program that reads a string from the user and counts
            //the number of vowels(a, e, i, o, u) in the string.
            Console.WriteLine("Please enter string");
            string input = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
  
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
