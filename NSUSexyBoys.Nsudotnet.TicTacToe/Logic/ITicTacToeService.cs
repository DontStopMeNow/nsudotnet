using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public interface ITicTacToeService
    {
        void MakeMove(int mainCol, int mainRow, int subCol, int subRow);
        Player GetPlayer1();
        Player GetPlayer2();
        int GetCurrentPlayer();
        int GetSub (int mainCol, int mainRow, int subCol, int subRow);
        int GetMain(int mainCol, int mainRow);
        void NewGame(String playerName1, String playerName2);
        Player GetWinner();
    }
}
