namespace Operators_Assignment_Submission
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public static bool operator ==(Employee emp1, Employee emp2) // Overload the equality operator to compare Employee objects based on their Id property
        {
            if (ReferenceEquals(emp1, emp2)) // Check if both references point to the same object
                return true;
            if (emp1 is null || emp2 is null) // Check if either of the Employee objects is null
                return false;
            return emp1.Id == emp2.Id; // Compare the Id properties of both Employee objects
        }

        public static bool operator !=(Employee emp1, Employee emp2) // Overload the inequality operator to compare Employee objects based on their Id property
        {
            return !(emp1 == emp2); // Use the overloaded equality operator to determine inequality
        }

    }
}
