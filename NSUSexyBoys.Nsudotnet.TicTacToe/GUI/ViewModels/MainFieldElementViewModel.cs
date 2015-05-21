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
    class MainFieldElement: FieldElementViewModel
    {
        public BindableCollection<SubFieldElementViewModel> Cells { get; set; }
        public MainFieldElement(int row, int column, Condition value, ITicTacToeService game) : base(row, column, value, game)
        {
            Cells = new BindableCollection<SubFieldElementViewModel>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new SubFieldElementViewModel(i/3, i%3, row, column, Condition.FREE, game));
            }
            SizeText = 50;
        }
    }
}
