namespace Class_Assignment_Method;

// Class containing mathematical operations
class MathOperations
{
    // Method to divide an integer by 2 using an out parameter
    public void Divide(int number, out int result)
    {
        result = number / 2;
    }

    // Method overload to divide a double by 2 using an out parameter
    public void Divide(double number, out double result)
    {
        result = number / 2.0;
    }

    // Static class for displaying results to the console
    static class Display
    {
        // Display method for integer results
        public static void ShowResult(int result)
        {
            Console.WriteLine($"Result: {result}");
        }

        // Display method overload for double results
        public static void ShowResult(double result)
        {
            Console.WriteLine($"Result: {result}");
        }
    }

    // Main program class
    class Program
    {
        // Entry point of the application
        static void Main(string[] args)
        {
            // Create an instance of MathOperations
            MathOperations mathOps = new MathOperations();

            // Prompt user for input
            Console.WriteLine("Enter a number: (Warning: Please enter decimals if you want to perform division with decimal numbers)");

            // Read user input from console
            string input = Console.ReadLine() ?? string.Empty;

            // Try parsing input as integer first
            if (int.TryParse(input, out int intNumber))
            {
                // Perform integer division and display result
                mathOps.Divide(intNumber, out int intResult);
                Display.ShowResult(intResult);
            }
            // If not an integer, try parsing as double
            else if (double.TryParse(input, out double doubleNumber))
            {
                // Perform double division and display result
                mathOps.Divide(doubleNumber, out double doubleResult);
                Display.ShowResult(doubleResult);
            }
            // Handle invalid input
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}