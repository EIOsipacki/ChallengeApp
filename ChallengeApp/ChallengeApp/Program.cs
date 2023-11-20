
using ChallengeApp;
var employee = new EmployeeEx("Adam", "Kamizelich");
int n = 80;
employee.AddGrades(n);
employee.AddGrades("4");
employee.AddGrades(6);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();


//Console.WriteLine($"Average: {statistics.Average:N2}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine($"Max: {statistics.Max}");

statistics.WriteLineStatistics();
statistics1.WriteLineStatistics();
statistics2.WriteLineStatistics();
statistics3.WriteLineStatistics();
statistics4.WriteLineStatistics();

