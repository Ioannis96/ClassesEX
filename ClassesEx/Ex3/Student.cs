using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student
    {
        private int Age;

        public void GoToClass()
        {
            Console.WriteLine("Going To Class");
        }

        public void SetAge(int age)
        {
            this.Age = age;
        }

        public void PrintAge()
        {
            Console.WriteLine($"My age is {Age} years old.");
        }

    }
}
