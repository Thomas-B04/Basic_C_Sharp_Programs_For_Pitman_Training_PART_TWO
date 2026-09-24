namespace Abstract_Class_Assignment
{
    public class Employee : Person // Inherits from the Person class
    {
        public int ID { get; set; } // Property for employee ID

        public override void SayName() // Implementation of the abstract method from the Person class
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
