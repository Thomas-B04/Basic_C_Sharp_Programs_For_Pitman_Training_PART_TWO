namespace Default_Value_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOps mathOps = new MathOps();
            Console.WriteLine("Enter an integer value for 'a':");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an integer value for 'b' (or press Enter to use the default value of 1):");
            string? input = Console.ReadLine();
            int result = string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int b)
                ? mathOps.Multiply(a) : mathOps.Multiply(a, b);
            Console.WriteLine($"Result of multiplication: {result}");
        }
    }
}