using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab7_Interface_3
{
    interface MusicPlayerInterface
    {
        void Switch(Boolean on);
        void play(Boolean on);
        void setVolume(int loudness);
        void playNext();
        void playPrevious();

    }
}
