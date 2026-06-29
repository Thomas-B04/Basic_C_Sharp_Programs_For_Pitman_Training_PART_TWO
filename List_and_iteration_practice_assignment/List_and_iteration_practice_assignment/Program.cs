using System;

/// <summary>
/// Provides small console exercises that demonstrate string/array/list handling
/// and iteration patterns across six independent practice parts.
/// </summary>
class Program
{
    /// <summary>
    /// Entry point that prompts the user to choose which exercise part to run.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Choose part to run (1, 2, 3, 4, 5, or 6):");
        string choice = Console.ReadLine() ?? "";

        if (choice == "1")
        {
            RunPartOne();
        }
        else if (choice == "2")
        {
            RunPartTwo();
        }
        else if (choice == "3")
        {
            RunPartThree();
        }
        else if (choice == "4")
        {
            RunPartFour();
        }
        else if (choice == "5")
        {
            RunPartFive();
        }
        else if (choice == "6")
        {
            RunPartSix();
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    /// <summary>
    /// Demonstrates iterating through an array and appending user-provided text
    /// to each element, then printing the updated values.
    /// </summary>
    static void RunPartOne()
    {
        string[] words = { "apple ", "banana ", "cherry ", "date ", "elderberry " };

        Console.WriteLine("This program will append your input to each word in the list.");

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

    /// <summary>
    /// Shows the difference between a non-terminating loop (missing increment)
    /// and a corrected while loop that terminates properly.
    /// </summary>
    static void RunPartTwo()
    {
        Console.WriteLine("Demonstrating a non-terminating loop (commented out to prevent infinite execution):");

        //int i = 0;
        //while (i < 5)
        //{
        //    Console.WriteLine(i);
        //}

        int i_fixed = 0;
        while (i_fixed < 5)
        {
            Console.WriteLine(i_fixed);
            i_fixed++; // prevents infinite loop
        }
    }

    /// <summary>
    /// Compares loop boundaries by printing values using both
    /// the &lt; and &lt;= operators.
    /// </summary>
    static void RunPartThree()
    {
        Console.WriteLine("Loop using the < operator:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nLoop using the <= operator:");

        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine(i);
        }
    }

    /// <summary>
    /// Searches a string array for a user-entered word and prints the first
    /// matching index, or a not-found message if no match exists.
    /// </summary>
    static void RunPartFour()
    {
        string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

        Console.WriteLine("This program will search for a word in the list of words and display its index if found.");

        Console.WriteLine("Enter a word to search for:");
        string userInput = Console.ReadLine() ?? "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] == userInput)
            {
                Console.WriteLine($"Found '{userInput}' at index {i}.");
                return;
            }
        }

        Console.WriteLine("Word not found.");
    }

    /// <summary>
    /// Searches a list that may contain duplicate names and prints every index
    /// where the entered name appears.
    /// </summary>
    static void RunPartFive()
    {
        List<string> names = ["John", "Jane", "Alice", "Bob", "Charlie", "Bob"];

        Console.WriteLine("This program will search for a name in the list of names and display all indices where it is found.");

        Console.WriteLine("Enter a name to search for:");
        string userInput = Console.ReadLine() ?? "";

        bool found = false;

        for (int i = 0; i < names.Count; i++) 
        {
            if (names[i] == userInput)
            {
                Console.WriteLine($"The name was found in the list at index {i}.");
                found = true;
            }
        }

        if (found == false)
        {
            Console.WriteLine("The name was not found in the list.");
        }
    }

    /// <summary>
    /// Iterates through a list and reports whether each item matches "C",
    /// demonstrating repeated-value checking during a foreach loop.
    /// </summary>
    static void RunPartSix()
    {
        List<string> letters = ["A", "B", "C", "D", "C"];

        Console.WriteLine("This program will check each letter in the list and report whether it is a 'C' or not.");

        foreach (string letter in letters)
        {
            if (letter == "C")
            {
                Console.WriteLine("Found a C!");
            }

            else
            {
                Console.WriteLine("Not a C.");
            }
        }
    }
}
