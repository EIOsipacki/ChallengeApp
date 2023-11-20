using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeEx
        {
        private List<float> grades = new List<float>();

        public EmployeeEx(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }


        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrades(string grade)
        {
            // var value= float.Parse(grade);
            if (float.TryParse(grade, out float result))
            {
                this.AddGrades(result);
            }
            else
            {
                Console.WriteLine("String is not Float");
            }
        }
        public void AddGrades(double grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }
        public void AddGrades(int grade)
        {
           var value = (float)grade;
           this.AddGrades(value);
        }
        public void AddGrades(long grade)
        {
            var value = (float)grade;
            this.AddGrades(value);
        }
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;

            //while (index < this.grades.Count)
            //{
            //    if (this.grades[index] ==5)
            //    {
            //        break;
            //    }
            //    statistics.Max = Math.Max(statistics.Max, grades[index]);
            //    statistics.Min = Math.Min(statistics.Min, grades[index]);
            //    statistics.Average += grades[index];
            //    index++;
            //}
            foreach (var grade in this.grades)
            {
                if( grade <0 )
                {
                    continue;
                }

                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        //goto  label:
        //goto label;
        //break;
        //continue;

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
                  
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i=0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += grades[i];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++; 
            } while (index < this.grades.Count);
           
            statistics.Average /= index;
            return statistics;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int index = 0;
            while (index < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Average += grades[index];
                index++;
            } 
            statistics.Average /= index;
            return statistics;
        }

    }


}
