using methods_and_objects_assignment;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new()
        {
            FirstName = "Sample",
            LastName = "Student",
            Id = 1
        };
        employee.SayName();
        employee.SayID();
    }
}