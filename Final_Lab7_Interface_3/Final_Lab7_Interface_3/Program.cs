using System;

namespace Final_Lab7_Interface_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ipod ipod = new Ipod();
            ipod.Musics();
            ipod.play(true);
            ipod.playNext();

            ipod.Switch(true);

            ipod.changeChannel();
            ipod.retune(88.8);
            ipod.setVolume(90);
        }
    }
}
