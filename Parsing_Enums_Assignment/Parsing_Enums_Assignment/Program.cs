namespace Parsing_Enums_Assignment
{
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a day of the week (e.g., Sunday, Monday, etc.) or type 'exit' to quit:");

                try
                {
                    string input = Console.ReadLine();
                    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    DaysOfWeek currentDay = Enum.Parse<DaysOfWeek>(input, true);
                    Console.WriteLine($"Have a nice {currentDay}");
                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
        }
    }
}