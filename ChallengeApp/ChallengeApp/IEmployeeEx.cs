using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{

    //interfejs = co bedziemy robić
    //publiczne zmienne, metody, propercje
    internal interface IEmployeeEx
    {
        string Name { get; }
        string Surname { get; }
        //dodamy wszystkie public metody
        void AddGrades(float grade);
        void AddGrades(string grade);
        void AddGrades(double grade);
        void AddGrades(int grade);
        void AddGrades(long grade);
        void AddGrades(char grade);
        Statistics GetStatistics();

        event GradeAddedDelegate GradeAdded;


    }
}
