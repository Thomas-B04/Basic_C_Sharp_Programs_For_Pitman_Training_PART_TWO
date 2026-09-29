namespace Operators_Assignment_Submission
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the equality operator to compare Employee objects based on their Id property
        public static bool operator ==(Employee emp1, Employee emp2) 
        {
            // Check if both references point to the same object
            if (ReferenceEquals(emp1, emp2)) 
                return true;
            // Check if either of the Employee objects is null
            if (emp1 is null || emp2 is null) 
                return false;
            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id; 
        }

        // Overload the inequality operator to compare Employee objects based on their Id property
        public static bool operator !=(Employee emp1, Employee emp2) 
        {
            // Use the overloaded equality operator to determine inequality
            return !(emp1 == emp2); 
        }

    }
}
