namespace Polymorphism_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Employee and set properties
            Employee employee = new()
            {
                FirstName = "John",
                LastName = "Doe",
                ID = 123
            };
            // Call the SayName method to display the employee's name
            employee.SayName();
            // Call the Quit method to indicate that the employee has quit
            employee.Quit();
        }
    }
}