
using ChallengeApp;
var employee = new EmployeeEx("Adam", "Kamizelich");
int n = 80;
employee.AddGrades(n);
employee.AddGrades("4");
employee.AddGrades('A');
var statistics = employee.GetStatistics();
statistics.WriteLineStatistics();


