using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Teacher
    {
        public string Subject;
        private int Age;

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public void PrintAge()
        {
            Console.WriteLine($"My age is {Age} years old.");
        }

        public void Explain()
        {
            Console.WriteLine("Explanation Begins");
        }
    }
}
