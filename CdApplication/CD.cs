using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class CD
    {
        public string Artist { get; set; }
        public double Price { get; set; }

        private List<Track> tracks;

        public CD()
        {
            tracks = new List<Track>();
        }
        public void AddTrack(Track track)
        {
            tracks.Add(track);
        }

        public void PrintData()
        {
            foreach(Track track in tracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
