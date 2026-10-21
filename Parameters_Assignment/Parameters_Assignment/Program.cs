using Parameters_Assignment;

internal class Program
{
    static void Main()
    {
        Employee<string> employee1 = new() // Create an instance of Employee with type parameter string
        {
            Things = ["John", "Jane", "Bob"] 
        };

        Employee<int> employee2 = new() // Create an instance of Employee with type parameter int
        {
            Things = [1, 2, 3]
        };

        foreach (string thing in employee1.Things)  // Iterate over the Things property of employee1 and print each string
        {
            Console.WriteLine(thing);
        }

        foreach (int thing in employee2.Things) // Iterate over the Things property of employee2 and print each int
        {
            Console.WriteLine(thing);
        }
    }
}