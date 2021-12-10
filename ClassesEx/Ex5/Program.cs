using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Track t1 = new Track("Possum", 185);
            Track t2 = new Track("Giraffe", 185);
            Track t3 = new Track("Catdog", 185);
            Track t4 = new Track("Pincer", 185);
            Track t5 = new Track("Scorpion", 185);
            Track t6 = new Track("Lagoon", 185);
            Track t7 = new Track("Scotland", 185);

            Track[] tracks = new Track[] { t1, t2, t3, t4, t5, t6, t7 };

            Cd myCd = new Cd("Animals and Shizz", tracks);

            Controller ct = new Controller();

            ct.Load(myCd);
            ct.ShowInfo();
            ct.Play();

            Console.ReadLine();

            Console.WriteLine("Press ESC to stop");

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.A))
            {
                Console.WriteLine("lalal");
            }


        }
    }
}
