namespace Calling_Methods_Assignment_Math_Operations
{
    class Program
    {
        static void Main()
        {
            MathOperations.MathOperations mathOps = new();
            int num1;
            while (true)
            {
                Console.WriteLine("Enter the first number:");

                string? input1 = Console.ReadLine();

                if (!int.TryParse(input1, out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                else
                {
                    break;
                }
            }

            int resultAdd = mathOps.Add(num1);
            int resultSubtract = mathOps.Subtract(num1);
            int resultMultiply = mathOps.Multiply(num1);
            double resultDivide = mathOps.Divide(num1);

            Console.WriteLine($"The result of adding 10 to {num1} is: {resultAdd}");
            Console.WriteLine($"The result of subtracting 10 from {num1} is: {resultSubtract}");
            Console.WriteLine($"The result of multiplying {num1} by 10 is: {resultMultiply}");
            Console.WriteLine($"The result of dividing {num1} by 10 is: {resultDivide}");
        }
    }
}