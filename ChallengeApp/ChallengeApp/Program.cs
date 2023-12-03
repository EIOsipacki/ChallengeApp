
using ChallengeApp;
using System;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

var employee = new EmployeeEx("adam", "mickiewicz");
var supervisor = new Supervisor("Adam", "Mickiewicz");

//Console.WriteLine($"name + surname={employee.Name} + {employee.SurName} / {employee.Age} / {employee.Sex} /");
//var employeename = new EmployeeEx("adam", 0);
//Console.WriteLine($"name + surname={employeename.Name} + {employeename.SurName}/ {employeename.Age} / {employeename.Sex} /");
//var employeenonamesurname = new EmployeeEx();
//Console.WriteLine($"name + surname={employeenonamesurname.Name} + {employeenonamesurname.SurName} / {employeenonamesurname.Age} / {employeenonamesurname.Sex} /");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    Console.WriteLine("Kliknij 'Q' żeby Exit");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try 
    {
        //employee.AddGrades(input);
        supervisor.AddGrades(input);
    }
    catch(Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statistics = supervisor.GetStatistics();
statistics.WriteLineStatistics();


