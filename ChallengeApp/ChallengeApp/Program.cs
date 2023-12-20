
using ChallengeApp;
using System;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine("__________statistics from MEMORY_____________");

var supervisor = new Supervisor("Adam", "Mickiewicz");
//EVENT
supervisor.GradeAdded += SupervisorGradeAdded;
//supervisor.GradeAdded += SupervisorGradeAdded2;
//supervisor.GradeAdded += SupervisorGradeAdded3;
void SupervisorGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine(" Dodano nową ocenę");
}

//supervisor.AddGrades(0.9f); 
Console.WriteLine($"Podaj ocenę pracownika {supervisor.Name } {supervisor.Surname} - lub 'Q' żeby skonczyć ");
while (true)
{
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try 
    {
        supervisor.AddGrades(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    Console.WriteLine("lub liknij 'Q' żeby Exit");
}
var statisticsfrommemory = supervisor.GetStatistics();
statisticsfrommemory.WriteLineStatistics();
Console.WriteLine("=============================================");
Console.WriteLine("Press any key to continue ...");
Console.ReadLine();
Console.Clear(); 
Console.WriteLine("=============================================");
Console.WriteLine("__________statistics from FILE _____________");

var employee = new EmployeeInFile("Jan", "Kowalski");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine(" Zapisano nową ocenę do pliku ");
}

Console.WriteLine($"Podaj ocenę pracownika {employee.Name} {employee.Surname} - lub 'Q' żeby skonczyć");
while (true)
{
   var inputgradetofile = Console.ReadLine();
    if (inputgradetofile == "q")
    {
        break;
    }
    try
    {
        employee.AddGrades(inputgradetofile);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"exception catched: {exception.Message}");
    }
    Console.WriteLine("podaj kolejną ocenę pracownika");
    Console.WriteLine(" lub kliknij 'q' żeby exit");
}
var statisticsfromfile = employee.GetStatistics(); 
statisticsfromfile.WriteLineStatistics();
Console.WriteLine("=============================================");
