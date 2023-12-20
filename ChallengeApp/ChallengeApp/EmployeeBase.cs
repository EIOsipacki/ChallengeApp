using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);
    public abstract class EmployeeBase : IEmployeeEx
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract event GradeAddedDelegate GradeAdded;
        public abstract void AddGrades(float grade);

        public abstract void AddGrades(string grade);

        public abstract void  AddGrades(double grade);

        public abstract void AddGrades(int grade);

        public abstract void AddGrades(long grade);

        public abstract void AddGrades(char grade);

        public abstract Statistics GetStatistics(); 
        
    }
}
