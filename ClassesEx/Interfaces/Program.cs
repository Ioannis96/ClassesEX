using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraph s = new Student();

            Student a = new Student();

            //s.koutamara den iparxei 

        }
    }

    interface IGraph
    {
        void Print();

        int Score { get; set; }

        int Age { get; set; }

    }

    class Student : IGraph
    {
        public string koutamara { get; set; } = "lalala";
        public int Score { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }

}
