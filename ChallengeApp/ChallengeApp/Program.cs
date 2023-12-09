
using ChallengeApp;
using System;

Console.WriteLine(" Witamy w Programie XVZ do oceny Pracowników");
Console.WriteLine("=============================================");
Console.WriteLine();

//var supervisor = new Supervisor("Adam", "Mickiewicz");

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika");
//    Console.WriteLine("Kliknij 'Q' żeby Exit");
//    var input = Console.ReadLine();
//    if (input == "q")
//    {
//        break;
//    }
//    try 
//    {
//        supervisor.AddGrades(input);
//    }
//    catch(Exception exception)
//    {
//        Console.WriteLine($"Exception catched: {exception.Message}");
//    }
//}
//var statistics = supervisor.GetStatistics();
//statistics.WriteLineStatistics();

var employee = new EmployeeInFile("Jan", "Kowalski");
while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    Console.WriteLine("Kliknij 'Q' żeby Exit");
    var inputfile = Console.ReadLine();
    if (inputfile == "q")
    {
        break;
    }
    try
    {
        employee.AddGrades(inputfile);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

