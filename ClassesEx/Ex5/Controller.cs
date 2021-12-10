using System;
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
                int i = 0;
                while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.A))
                {
                    Console.WriteLine("lalal");
                }
            }
        }

        public void Stop()
        {

        }

        public void Next()
        {

        }

        public void Previous()
        {

        }
    }




}
