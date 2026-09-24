namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main()
        {
            // Entry point for the application
            // Create an Employee object, set its properties, and call the SayName implementation
            Employee employee = new()
            {
                // Set the first and last name inherited from Person
                FirstName = "John",
                LastName = "Doe",
                // Set the employee-specific ID
                ID = 123
            };

            // Calls Employee.SayName(), which implements the abstract method from Person
            employee.SayName();
        }
    }
}