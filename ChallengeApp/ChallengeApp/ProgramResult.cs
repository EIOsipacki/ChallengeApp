using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class ProgramResult
    {
        
        public ProgramResult(Employee employeeResult, int programResultMaxPunkt)
        {
            this.EmployeeResult = employeeResult;
            this.ProgramResultMaxPunkt = programResultMaxPunkt;
        }
        public Employee EmployeeResult { get;private set; }
        public int ProgramResultMaxPunkt { get;private  set; }

        public void PrintProgramResult()
        {
            Console.WriteLine(EmployeeResult.Nazwisko+" "+EmployeeResult.Name+", wiek="+ EmployeeResult.Wiek+ "  = "+ ProgramResultMaxPunkt); 
        }


    }

    
}

