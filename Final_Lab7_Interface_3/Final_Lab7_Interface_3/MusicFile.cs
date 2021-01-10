using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab7_Interface_3
{
    class MusicFile
    {
        private string title;
        private string artist;
        private int yearOfRelease;
        private int durationInSeconds;

        public MusicFile()
        {
            title = "Tare Bole dio";
            artist = "Hemanta Mukherjee";
            yearOfRelease = 1961;
            durationInSeconds = 193;
        }

        public MusicFile(string title, string artist, int yearOfRelease, int durationInSeconds)
        {
            this.title = title;
            this.artist = artist;
            this.yearOfRelease = yearOfRelease;
            this.durationInSeconds = durationInSeconds;
        }
        public void changeTitle(string title)
        {
            this.title = title;
        }
    }
}
