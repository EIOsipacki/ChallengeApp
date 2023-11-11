using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string nazwisko, int wiek )
        {
            this.Name = name;
            this.Nazwisko = nazwisko;
            this.Wiek = wiek;
        }
        public string Name { get; private set; }
        public string Nazwisko { get; private set; }

        public int Wiek { get; private set; }

        public int SumaPunkty
        {
            get
            {
                return this.score.Sum();
            }
        }
        public int MaxPunkty
        {
            get
            {
                return this.score.Max();
            }
        }
        public void AddPunkty(int punkty)
        {
            this.score.Add(punkty);
        }
    }
}
