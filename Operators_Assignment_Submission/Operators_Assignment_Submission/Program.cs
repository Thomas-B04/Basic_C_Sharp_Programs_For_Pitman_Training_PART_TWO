using Operators_Assignment_Submission;

// Create two Employee objects with different Ids

Employee emp1 = new() { Id = 1, FirstName = "John", LastName = "Doe" };
Employee emp2 = new() { Id = 2, FirstName = "Jane", LastName = "Smith" };

// Compare the two Employee objects using the overloaded equality and inequality operators
// The output will be False for the equality operator and True for the inequality operator

Console.WriteLine(emp1 == emp2); 
Console.WriteLine(emp1 != emp2); 