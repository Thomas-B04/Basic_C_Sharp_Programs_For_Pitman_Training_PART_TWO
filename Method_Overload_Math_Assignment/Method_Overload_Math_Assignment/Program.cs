namespace Method_Overload_Math_Assignment
{
    public class Program
    {
        static void Main() // Entry point of the program
        {
            MathMethods math = new MathMethods();
            Console.WriteLine(math.MathOps(10)); // Output: 15
            Console.WriteLine(math.MathOps(10.5m)); // Output: 21
            Console.WriteLine(math.MathOps("20")); // Output: 30
        }
    }
}