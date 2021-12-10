using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Controller
    {
        private Cd cd;

        public void Load(Cd cd)
        {
            this.cd = cd;
        }

        public void ShowInfo()
        {
            if (cd == null)
            {
                Console.WriteLine("Cannot show Info because there is no CD loaded");
            }
            else
            {
                Console.WriteLine($"CD Title: {cd.GetTitle()} \nTrack Number: {cd.GetNumberOfTracks()}");
            }
        }

        public void Play()
        {
            if (cd == null)
            {
                Console.WriteLine("Cannot play because there is no CD loaded");
            }
            else
            {
                ConsoleKeyInfo cki;
                int i = 0;
                do
                {
                    Console.WriteLine($"Playing: {cd.GetTracks()[i].GetTitle()}");

                    Thread.Sleep(250);

                    cki = Console.ReadKey(true);

                    if (cki.Key == ConsoleKey.B || cki.Key == ConsoleKey.S || cki.Key == ConsoleKey.N)
                    {
                        switch (cki.Key)
                        {
                            case ConsoleKey.B:
                                i = Previous(i);
                                break;

                            case ConsoleKey.N:
                                i = Next(i, cd.GetNumberOfTracks());
                                break;

                            case ConsoleKey.S:
                                Stop();
                                break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvaid Key\n");
                        Console.ResetColor();
                    }

                } while (cki.Key != ConsoleKey.S);
            }
        }

        public void Stop()
        {
            Console.WriteLine("Stopped");
        }

        public int Next(int n, int trackNum)
        {
            Console.WriteLine("Next Song..");

            if (n == trackNum-1)
            {
                return 0;
            }
            else
            {
                return n+1;
            }
        }

        public int Previous(int n)
        {
            Console.WriteLine("Previous Song..");

            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n - 1;
            }
        }
    }




}
