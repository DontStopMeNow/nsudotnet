using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Data;
using Logic;

namespace GUI.ViewModels
{
    class MainFieldElementViewModel: FieldElementViewModel
    {
        public BindableCollection<SubFieldElementViewModel> Cells { get; set; }
        private MainViewModel _mainFild;
        public MainFieldElementViewModel(int row, int column, Condition value, MainViewModel mainFild, ITicTacToeService game)
            : base(row, column, value, game)
        {
            _mainFild = mainFild;
            Cells = new BindableCollection<SubFieldElementViewModel>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new SubFieldElementViewModel(i/3, i%3, this, Condition.FREE, game));
            }
            SizeText = 50;
        }

        public void Refresh()
        {
            NotifyOfPropertyChange(() => Value);
            _mainFild.Refresh();
        }
    }
}
