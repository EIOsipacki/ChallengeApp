
using ChallengeApp;
var employee = new EmployeeEx("Adam", "Kamizelich");
int n = 80;
employee.AddGrades(n);
employee.AddGrades("5");
employee.AddGrades(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
