using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Data;
using Logic;

namespace GUI.ViewModels
{
    class MainViewModel : PropertyChangedBase
    {
        private ITicTacToeService _game;
        public BindableCollection<MainFieldElement> Cells { get; set; }
        public MainViewModel(ITicTacToeService game)
        {
            _game = game;
            Cells = new BindableCollection<MainFieldElement>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new MainFieldElement(i/3, i%3, Condition.FREE, game));
            }
        }
    }
}
