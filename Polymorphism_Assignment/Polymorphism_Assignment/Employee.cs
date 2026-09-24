namespace Polymorphism_Assignment
{

    public class Employee : Person, IQuittable // Inherits from the Person class and implements the IQuittable interface
    {
        public int ID { get; set; } // Property for employee ID

        public override void SayName() // Implementation of the abstract method from the Person class
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        public void Quit() // Implementation of the Quit method from the IQuittable interface
        {
            Console.WriteLine($"{FirstName} {LastName} has quit.");
        }
    }
}
