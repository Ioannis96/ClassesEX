using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Cd
    {
        private string Title;
        private Track[] Tracks;
        private int NumberOfTracks;

        public Cd(string title, Track[] tracks)
        {
            this.Title = title;
            this.Tracks = tracks;
            this.NumberOfTracks = tracks.Count();   
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public Track[] GetTracks()
        {
            return Tracks;
        }

        public int GetNumberOfTracks()
        {
            return this.NumberOfTracks;
        }
    }
}
