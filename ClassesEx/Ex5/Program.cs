using System;
using System.Threading;
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


            ConsoleKeyInfo cki;
            do
            {
                Console.WriteLine("press mpla for mpla");
                Console.WriteLine("press mpla for mpla");
                Console.WriteLine("press mpla for mpla");

                cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.Q:
                        //show list
                        break;

                    case ConsoleKey.L:
                        //selection
                        ct.Load(myCd);
                        break;

                    case ConsoleKey.X:
                        Console.WriteLine("See you later..");
                        break;
                }

                Console.WriteLine();
            } while (cki.Key != ConsoleKey.X && cki.Key != ConsoleKey.L);

            //epilogh gia to LOADED CD ----------------------------------------------------- //
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
