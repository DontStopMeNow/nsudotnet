﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic;

namespace GUI.ViewModels
{
    public abstract class FieldElementViewModel
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public char Value { get; set; }
        public int SizeText { get; set; }
        protected ITicTacToeService _game;
        protected FieldElementViewModel(int row, int column, Condition value, ITicTacToeService game)
        {
            Row = row;
            Column = column;
            _game = game;
            switch (value)
            {
                case Condition.FREE:
                    Value = ' ';
                    break;
                case Condition.CROSS:
                    Value = 'x';
                    break;
                case Condition.ZERO:
                    Value = 'o';
                    break;
            }
        }
    }
}
