using System;

class Program
{
    static void Main()
    {
        string[] words = { "apple ", "banana ", "cherry ", "date ", "elderberry " };
        
        Console.WriteLine("Enter some text to add to the end of each word:");
        string userInput = Console.ReadLine() ?? "";

        for (int i = 0; i < words.Length; i++)
        {
            words[i] += userInput;
        }

        Console.WriteLine("\nUpdated words:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}