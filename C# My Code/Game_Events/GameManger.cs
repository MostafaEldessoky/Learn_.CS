using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Events
{
    internal class GameManger
    {
        public delegate void game_manger();

        public static event game_manger startgame, endgame;


        public static void starttrigger()
        {
            startgame();
        }
        public static void endtrigger()
        {
            endgame();
        }
    }
}
