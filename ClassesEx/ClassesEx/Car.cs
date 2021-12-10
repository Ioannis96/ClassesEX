using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEx

{
    class Car
    {
        public string name;
        public Car(string name)
        {
            this.name = name;
        }
        public void Start()
        {
            Console.WriteLine("Car Started");
        }
        public string GetName()
        {
            return name;
        }
    }
}