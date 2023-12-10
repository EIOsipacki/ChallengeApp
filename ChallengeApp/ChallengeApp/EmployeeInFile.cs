
namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        private List<float> grades = new List<float>();
        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                //this.grades.Add(grade);
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
            
        }

        public override void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                throw new Exception("String is not a float");
            }
        }

        public override void AddGrades(double grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }

        public override void AddGrades(int grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }

        public override void AddGrades(long grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }

        public override void AddGrades(char grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                if (grade < 0)
                {
                    continue;
                }
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
