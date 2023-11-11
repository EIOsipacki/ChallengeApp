using ChallengeApp;
using System.Diagnostics.Metrics;
using System.Numerics;
//EXAMPLE
/*
User user1 = new User("Adam", "2342423");
User user2 = new User("Dzordz","PAS123");
User user3 = new User("Dzordz", "1234qwer");
User user4 = new User("Anna", "112111");
User user5 = new User("Damian", "asdfqwer");

var name = user1.Login;
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
*/
// END EXAMPLE

Employee Employee1 = new Employee("Jan", "Kowalczyk", 33);
Employee Employee2 = new Employee("Sylwia", "Nowak", 28);
Employee Employee3 = new Employee("Grzegorz", "Mocko", 38);

Employee1.AddPunkty(2);
Employee2.AddPunkty(4);
Employee3.AddPunkty(1);

Employee1.AddPunkty(5);
Employee2.AddPunkty(8);
Employee3.AddPunkty(9);

Employee1.AddPunkty(3);
Employee2.AddPunkty(8);
Employee3.AddPunkty(1);

Employee1.AddPunkty(2);
Employee2.AddPunkty(3);
Employee3.AddPunkty(4);

Employee1.AddPunkty(8);
Employee2.AddPunkty(1);
Employee3.AddPunkty(7);

ProgramResult ProgramResult1 = new ProgramResult(Employee1, Employee1.MaxPunkty);
ProgramResult ProgramResult2 = new ProgramResult(Employee2, Employee2.MaxPunkty);
ProgramResult ProgramResult3 = new ProgramResult(Employee3, Employee3.MaxPunkty);
/*
//ProgramResult1.PrintProgramResult();
//ProgramResult2.PrintProgramResult();
//ProgramResult3.PrintProgramResult();

//Console.WriteLine("Emplojee -> " + Employee1.Name + " " + Employee1.Nazwisko + " = "+ Employee1.SumaPunkty);
//Console.WriteLine("Emplojee -> " + Employee2.Name + " " + Employee2.Nazwisko + " = "+ Employee2.SumaPunkty);//
//Console.WriteLine("Emplojee -> " + Employee3.Name + " " + Employee3.Nazwisko + " = "+ Employee3.SumaPunkty);
//Console.WriteLine("Emplojee -> " + Employee1.Name + " " + Employee1.Nazwisko + " Maksimalny punkt = " + Employee1.MaxPunkty);
//Console.WriteLine("Emplojee -> " + Employee2.Name + " " + Employee2.Nazwisko + " Maksimalny punkt = " + Employee2.MaxPunkty);
//Console.WriteLine("Emplojee -> " + Employee3.Name + " " + Employee3.Nazwisko + " Maksimalny punkt = " + Employee3.MaxPunkty);
*/

List <ProgramResult> programResults = new List <ProgramResult>();

programResults.Add (ProgramResult1);
programResults.Add (ProgramResult2);
programResults.Add (ProgramResult3);

int pozycjaMax = 0;
int counter = 0;
int maxElement = 0;

//int mm = programResults.Max ????
//nie wiem syntaxu; 



foreach(ProgramResult item in programResults)
 {
        if (item.ProgramResultMaxPunkt >= maxElement)
    {
        pozycjaMax = counter;
        maxElement = item.ProgramResultMaxPunkt;
    }
    counter++;
    item.PrintProgramResult();
 }
Console.WriteLine("ODPOWIEDZ: max ocena u Pracownika ");
programResults[pozycjaMax].PrintProgramResult();




