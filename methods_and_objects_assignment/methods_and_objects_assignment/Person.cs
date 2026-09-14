namespace methods_and_objects_assignment
{
    internal class Person
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}

