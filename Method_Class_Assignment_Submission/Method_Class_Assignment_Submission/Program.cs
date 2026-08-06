namespace Method_Class_Assignment_Submission
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the MathOperations class.
            MathOperations math = new MathOperations();

            // Call MathOps with positional arguments: first argument maps to num1, second to num2.
            math.MathOps(10, 50);

            // Print a blank line to separate output sections for readability.
            Console.WriteLine();

            // Call MathOps with named arguments to explicitly show parameter mapping.
            math.MathOps(num1: 30, num2: 50);
        }
    }
}