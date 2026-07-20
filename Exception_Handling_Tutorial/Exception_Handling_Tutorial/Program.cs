using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Pick a number: ");

            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick another number: ");

            int numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dividing the two numbers...");

            int numberThree = numberOne / numberTwo;

            Console.WriteLine($"{numberOne} divided by {numberTwo} is {numberThree}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by zero.");
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.ReadLine();
        }

    //Better version:
    //static void Main()
    //{
    //    Console.WriteLine("Pick a number: ");
    //    int numberOne;
    //    while (!int.TryParse(Console.ReadLine(), out numberOne))
    //    {
    //        Console.WriteLine("Invalid input. Please enter a valid number:");
    //    }

    //    Console.WriteLine("Pick another number: ");
    //    int numberTwo;
    //    while (!int.TryParse(Console.ReadLine(), out numberTwo) || numberTwo == 0)
    //    {
    //        Console.WriteLine("Invalid input. Please enter a valid number (not zero):");
    //    }

    //    Console.WriteLine("Dividing the two numbers...");
    //    int numberThree = numberOne / numberTwo;
    //    Console.WriteLine($"{numberOne} divided by {numberTwo} is {numberThree}");
    //}
}
}