
namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrades(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrades(string grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrades(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrades(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrades(long grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override void AddGrades(char grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }

        public override Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
