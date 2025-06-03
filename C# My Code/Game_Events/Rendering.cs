using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Events
{
    internal class Rendering
    {
        public Rendering()
        {
            GameManger.startgame += RunRendering;
            GameManger.endgame +=  StopRendering;
        }

        private void RunRendering()
        {
            Console.WriteLine("Rendering is Running");
        }

        private void StopRendering()
        {
            Console.WriteLine("Rendering is Stoped");
        }
    }
}
