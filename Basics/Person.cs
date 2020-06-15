using System;

namespace Learning_CSharp
{
    class Person
    {
        string name;
        short birthYear;
        public short age
        {
            get
            {
                var date = DateTime.Today.Year;
                return (short)(date - birthYear);
            }
        }
        public Person(string name)
        {
            this.name = name;
        }
        public Person(string name, short birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public void SayMyName()
        {
            Console.WriteLine($"{this.name}!!!");
        }

    }
}