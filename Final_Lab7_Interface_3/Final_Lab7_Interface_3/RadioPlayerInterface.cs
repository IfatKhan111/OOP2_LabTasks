using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Lab7_Interface_3
{
    interface RadioPlayerInterface
    {
        void Switch(Boolean on);
        void retune(double frequency);
        void setVolume(int loudness);
        void changeChannel();

    }
}
