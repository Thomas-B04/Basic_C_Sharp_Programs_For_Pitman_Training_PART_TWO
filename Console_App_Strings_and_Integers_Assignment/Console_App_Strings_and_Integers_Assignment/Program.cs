using System;


class Program
{
    static void Main()
    {
        List<int> numbers = [22, 32, 55, 77, 88, 99, 100];
        Console.WriteLine($"The numbers in the list are {numbers.Count}");


        while (true)
        {
            Console.WriteLine("Please enter a number to divide each number in the list by:");
            try
            {
                int divisor = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numbers)
                {
                    Console.WriteLine($"{number} divided by {divisor} is {(double)number / divisor:F2}");
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide by zero. Please try again.");
                continue;

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                continue;
            }
        }
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = [22, 32, 55, 77, 88, 99, 100];
//        Console.WriteLine($"The numbers in the list are {numbers}");

//        while (true)
//        {
//            Console.WriteLine("Please enter a whole number to divide each number in the list by:");

//            string? input = Console.ReadLine();

//            if (!int.TryParse(input, out int divisor))
//            {
//                Console.WriteLine("That is not a valid whole number. Try again.");
//                continue;
//            }

//            if (divisor == 0)
//            {
//                Console.WriteLine("You cannot divide by zero. Try again.");
//                continue;
//            }

//            foreach (int number in numbers)
//            {
//                Console.WriteLine($"{number} divided by {divisor} is {(double)number / divisor:F2}");
//            }

//            break; // success -> exit loop
//        }

//        Console.WriteLine("Program continued after handling errors.");
//    }
//}