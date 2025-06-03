using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Events
{
    internal class Audio
    {
        public Audio() 
        {
            GameManger.startgame += RunAudio;
            GameManger.endgame += StopAudio;
        }

        private void RunAudio()
        {
            Console.WriteLine("Audio is Running");
        }

        private void StopAudio()
        {
            Console.WriteLine("Audio is Stoped");
        }
    }
}
