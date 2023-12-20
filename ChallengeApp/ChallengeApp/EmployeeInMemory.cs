
namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase 
    {
        //public delegate void GradeAddedDelegate(object sender, EventArgs args);

       // public event GradeAddedDelegate GradeAdded; 

        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }
        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);  
        }
        private void WriteMessageInConsole2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        private List<float> grades = new List<float>();

        public override event GradeAddedDelegate GradeAdded;

        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
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
