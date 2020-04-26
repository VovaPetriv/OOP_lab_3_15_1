using System;

namespace OOP_lab_3_15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            str = str.ToLower();

            string[] words = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();

            foreach (string word in words)
            {
                if (word.Trim(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }).Length % 2 == 0)
                {
                    Console.WriteLine(word.Trim(new char[] { ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*' }));
                }
            }    
        }
    }
}
