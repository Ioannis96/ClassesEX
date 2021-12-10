using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.SetAge(30);

            Student s1 = new Student();
            s1.SetAge(21);

            s1.PrintAge();
            s1.GoToClass();

            t1.Explain();

            Console.ReadLine();
        }
    }
}
