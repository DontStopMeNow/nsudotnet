using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Logic;

namespace GUI.ViewModels
{
    class SubFieldElementViewModel: FieldElementViewModel
    {
        private readonly int _parentRow;
        private readonly int _parentColumn;
        public SubFieldElementViewModel(int row, int column,int parentRow, int parentColumn, Condition value, ITicTacToeService game) : base(row, column, value, game)
        {
            _parentRow = parentRow;
            _parentColumn = parentColumn;
            SizeText = 10;
        }

        public void Click()
        {
            _game.MakeMove(_parentRow, _parentColumn, Row, Column);
        }
    }
}
