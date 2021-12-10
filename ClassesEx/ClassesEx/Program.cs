using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEx

{
    class Program
    {
        static void Main(string[] args)
        {
            Car exampleCar = new Car("Scirocco");
            Console.WriteLine(exampleCar.GetName());
            Console.ReadLine();
        }
    }
}
