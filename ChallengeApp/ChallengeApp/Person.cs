﻿
namespace ChallengeApp
{
    public abstract class Person
    {
       // protected int counter;
        public Person(string name, string surname, string sex)
        { 
            this.Name = name;
            this.SurName = surname;
            this.Sex = sex;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }
        public string Sex { get; private set; }
    }
}
