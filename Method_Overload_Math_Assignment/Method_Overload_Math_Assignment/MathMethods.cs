namespace Method_Overload_Math_Assignment
{
    public class MathMethods
    {
        public int MathOps(int number)
        {
            return number + 5; // Adds 5 to the integer input   
        }

        public int MathOps(decimal number)
        {
            return (int)(number * 2); // Multiplies the decimal input by 2 and converts it to an integer
        }

        public int MathOps(string number)
        {
            if (int.TryParse(number, out int result))
            {
                return result + 10;
            }

            Console.WriteLine($"Invalid input '{number}': Please provide a valid integer string, returning Zero.");
            return 0;
        }
    }
}
