namespace Abstract_Class_Assignment
{
    // Abstract class representing a person
    public abstract class Person // Abstract class cannot be instantiated directly, but can be inherited by other classes
    {
        // Properties for first name and last name
        public string FirstName { get; set; } 
        public string LastName { get; set; }

        // Abstract method to be implemented by derived classes, forcing them to provide their own implementation of SayName
        public abstract void SayName();
    }
}
