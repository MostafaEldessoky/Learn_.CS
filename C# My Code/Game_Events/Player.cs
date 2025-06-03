using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Events
{
    internal class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            Name = name;
            GameManger.startgame += RunPlayer;
            GameManger.endgame += StopPlayer;
        }

        private void RunPlayer()
        {
            Console.WriteLine($"Player {Name} is Running");
        }

        private void StopPlayer()
        {
            Console.WriteLine($"Player {Name} is Stoped");
        }
    }
}
