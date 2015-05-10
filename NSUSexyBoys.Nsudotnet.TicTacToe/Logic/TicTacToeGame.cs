using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    class TicTacToeGame
    {
        public MainField Field { get; set; }
        public Player[] Players;
        private int _currentPlayer;

        public TicTacToeGame(MainField field, Player p1, Player p2)
        {
            Players = new Player[2];
            Players[0] = p1;
            Players[1] = p2;
            Field = field;
        }

        public void SetPlayer1(Player player)
        {
            Players[0] = player;
        }

        public void SetPlayer2(Player player)
        {
            Players[1] = player;
        }

        public Player GetPlayer1()
        {
            return Players[0];
        }

        public Player GetPlayer2()
        {
            return Players[1];
        }
    }
}
