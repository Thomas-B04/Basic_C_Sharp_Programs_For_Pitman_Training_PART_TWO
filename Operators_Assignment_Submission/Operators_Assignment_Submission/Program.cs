using Operators_Assignment_Submission;

Employee emp1 = new() { Id = 1, FirstName = "John", LastName = "Doe" }; // Create an instance of Employee with Id 1
Employee emp2 = new() { Id = 2, FirstName = "Jane", LastName = "Smith" }; // Create an instance of Employee with Id 2

Console.WriteLine(emp1 == emp2); // Output: False, because emp1 and emp2 have different Ids
Console.WriteLine(emp1 != emp2); // Output: True, because emp1 and emp2 have different Ids