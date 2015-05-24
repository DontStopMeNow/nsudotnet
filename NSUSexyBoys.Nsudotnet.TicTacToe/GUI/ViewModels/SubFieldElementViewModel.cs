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
        private readonly MainFieldElementViewModel _mainFild;
        public SubFieldElementViewModel(int row, int column, MainFieldElementViewModel mainField, Condition value, ITicTacToeService game)
            : base(row, column, value, game)
        {
            _mainFild = mainField;
            SizeText = 10;
        }

        public void Click()
        {
            _game.MakeMove(_mainFild.Column, _mainFild.Row, Column, Row);
            Value = _game.GetSub(_mainFild.Column, _mainFild.Row, Column, Row);
            _mainFild.Value = _game.GetMain(_mainFild.Column, _mainFild.Row);
            _mainFild.Refresh();
            NotifyOfPropertyChange(() => Value);
        }
    }
}
