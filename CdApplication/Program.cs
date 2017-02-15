using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Track track1 = new Track();
            track1.Name = "Shudder Before the Beautiful, ";
            track1.Duration = "6:29";

            Track track2 = new Track();
            track2.Name = "Weak Fantasy, ";
            track2.Duration = "5:23";

            Track track3 = new Track();
            track3.Name = "Elan, ";
            track3.Duration = "4:45";

            Track track4 = new Track();
            track4.Name = "Yours Is an Empty Hope, ";
            track4.Duration = "5:34";

            Track track5 = new Track();
            track5.Name = "Our Decades in the Sun, ";
            track5.Duration = "6:37";

            Track track6 = new Track();
            track6.Name = "My Walden, ";
            track6.Duration = "4:45";

            Track track7 = new Track();
            track7.Name = "Endless Forms Most Beautiful, ";
            track7.Duration = "5:07";

            Track track8 = new Track();
            track8.Name = "Edema Ruh, ";
            track8.Duration = "5:15";

            Track track9 = new Track();
            track9.Name = "Alpenglow, ";
            track9.Duration = "4:45";

            Track track10 = new Track();
            track10.Name = "The Eyes of Sharbat Gula, ";
            track10.Duration = "6:03";

            Track track11 = new Track();
            track11.Name = "The Greatest Show on Earth, ";
            track11.Duration = "24:00";

            CD cd = new CD();
            Console.WriteLine("CD data: ");
            Console.WriteLine("--------------------------------");
            cd.Artist = "Artist: Nightwish";
            Console.WriteLine(cd.Artist);
            Console.WriteLine("Songs: ");
            cd.AddTrack(track1);
            cd.AddTrack(track2);
            cd.AddTrack(track3);
            cd.AddTrack(track4);
            cd.AddTrack(track5);
            cd.AddTrack(track6);
            cd.AddTrack(track7);
            cd.AddTrack(track8);
            cd.AddTrack(track9);
            cd.AddTrack(track10);
            cd.AddTrack(track11);
            cd.PrintData();
            Console.WriteLine("--------------------------------");

        }
    }
}
