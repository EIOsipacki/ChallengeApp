
using System.Reflection.PortableExecutable;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override event GradeAddedDelegate GradeAdded;

        //private List<float> grades = new List<float>();
        public override void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                //this.grades.Add(grade);
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                // this.grades.Add(grade);
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
            string line;
            Console.WriteLine("--------Treść zapisanego pliku ----------- ");
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    int kollines = 1;
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        float result = float.Parse(line);
                        Console.WriteLine($"{kollines} stroka = {result}");
                        statistics.AddGrade(result);

                        line = reader.ReadLine();
                        kollines++;
                    }
                    //statistics.Average /= (kollines - 1);
                }
                
            }
            return statistics;
        }
    }
}

  