using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab7_Interface_3
{
    class Ipod : RadioPlayerInterface, MusicPlayerInterface
    {

        MusicFile[] musics = new MusicFile[500];


        public void Musics()
        {
            MusicFile track = new MusicFile();
            musics[0] = track;
            track = new MusicFile("You're Beautiful", "James Blunt", 2004, 321);
            musics[1] = track;
        }


        public void changeChannel()
        {
            Console.WriteLine("Change Channnel");
        }

        public void play(bool on)
        {
            Console.WriteLine("Playing");
        }

        public void playNext()
        {
            Console.WriteLine("Play next");
        }

        public void playPrevious()
        {
            Console.WriteLine("Play previous");
        }

        public void retune(double frequency)
        {
            Console.WriteLine("tuning at " + frequency);
        }

        public void setVolume(int loudness)
        {
            Console.WriteLine("Volume set at " + loudness);
        }

        public void Switch(bool on)
        {
            Console.WriteLine("Switch");
        }

    }
}
