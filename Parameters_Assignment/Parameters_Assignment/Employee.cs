namespace Parameters_Assignment
{
    internal class Employee<T> // Generic class with type parameter T
    {
        public List<T> Things { get; set; } = new List<T>(); // Property of type List<T> to hold a collection of things of type T

    }
}
