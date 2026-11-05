using Struct_Assignment;

internal class Program
{
    // Entry point of the program
    private static void Main()
    {
        // Create an instance of the Number struct and set the Amount property
        Number number = new()
        {
            Amount = 100.50m
        };

        // Display the value of the Amount property
        Console.WriteLine($"The amount is: {number.Amount}"); 
    }
}