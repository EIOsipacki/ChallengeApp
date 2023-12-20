
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
            foreach(var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
     }
}
