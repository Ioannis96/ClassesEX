using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Track
    {
        private string Title;
        private int Duration;

        public Track(string title, int duration)
        {
            this.Title = title;
            this.Duration = duration;
        }

        public string GetTitle()
        {
            return this.Title;
        }

        public int GetDuration()
        {
            return this.Duration;
        }

    }
}
