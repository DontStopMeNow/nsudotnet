﻿using System;
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
        private Player[] _players;
        private int _currentPlayer;
        private SubField _lastPicked;

        public TicTacToeGame(MainField field, Player p1, Player p2)
        {

            _players = new Player[2];
            _players[0] = p1;
            _players[1] = p2;
            Field = field;
            _lastPicked = null;
        }

        public void MakeMove(int MainCol, int MainRow, int SubCol, int SubRow)
        {
            if (!MoveValidation(MainCol, MainRow, SubCol, SubRow)) return;
            _lastPicked = Field.Cells[SubCol, SubRow];
            Field.Cells[MainCol, MainRow].Cells[SubCol, SubRow] = _players[_currentPlayer].TypeLabel;
            Field.Cells[MainCol, MainRow].FreeCells--;

            UpdateSubCondition(MainCol, MainRow);
            UpdateMainCondition();
            ChangePlayer();
        }

        public Player GetWinner()
        {
            if (_players[0].TypeLabel.Equals(Field.Condition))
                return _players[0];
            if (_players[1].TypeLabel.Equals(Field.Condition))
                return _players[1];
            return null;
        }
        private void UpdateMainCondition()
        {
            var mainCells = Field.Cells;

            for (var i = 0; i < 3; i++)
            {
                if ((mainCells[i, 0].Condition == mainCells[i, 1].Condition) && 
                    (mainCells[i, 1].Condition == mainCells[i, 2].Condition))
                {
                    Field.Condition = mainCells[i, 0].Condition;
                }
                if ((mainCells[0, i].Condition == mainCells[1, i].Condition) && 
                    (mainCells[1, i].Condition == mainCells[2, i].Condition))
                {
                    Field.Condition = mainCells[0, i].Condition;
                }
            }
            if ((mainCells[0, 0].Condition == mainCells[1, 1].Condition) && 
                (mainCells[1, 1].Condition == mainCells[2, 2].Condition))
            {
                Field.Condition = mainCells[0, 0].Condition;
            }
            if ((mainCells[2, 0].Condition == mainCells[1, 1].Condition) && 
                (mainCells[1, 1].Condition == mainCells[0, 2].Condition))
            {
                Field.Condition = mainCells[1, 1].Condition;
            }
        }
        private void UpdateSubCondition(int MainCol, int MainRow)
        {
            var subField = Field.Cells[MainCol, MainRow];
            var subCells = subField.Cells;
            Field.FreeCells--;
            for (var i = 0; i < 3; i++)
            {
                if ((subCells[i, 0] == subCells[i, 1]) && (subCells[i, 1] == subCells[i, 2]))
                {
                    subField.Condition = subCells[i, 0];
                    return;
                }
                if ((subCells[0, i] == subCells[1, i]) && (subCells[1, i] == subCells[2, i]))
                {
                    subField.Condition = subCells[0, i];
                    return;
                }
            }
            if ((subCells[0, 0] == subCells[1, 1]) && (subCells[1, 1] == subCells[2, 2]))
            {
                subField.Condition = subCells[0, 0];
                return;
            }
            if ((subCells[2, 0] == subCells[1, 1]) && (subCells[1, 1] == subCells[0, 2]))
            {
                subField.Condition = subCells[1, 1];
                return;
            }
            Field.FreeCells++;
        }
       
        private void ChangePlayer()
        {
            _currentPlayer = (_currentPlayer + 1) % 2;
        }
        private bool MoveValidation(int MainCol, int MainRow, int SubCol, int SubRow)
        {
            if (_lastPicked == null) 
                return true;
            if (_lastPicked.FreeCells == 0 &&
                Field.Cells[MainCol, MainRow].Cells[SubCol, SubRow].Equals(Condition.FREE))
                return true;
            if (Field.Cells[MainCol, MainRow] == _lastPicked &&
                Field.Cells[MainCol, MainRow].Cells[SubCol, SubRow].Equals(Condition.FREE))
                return true;

            return false;

        }
    }
}
