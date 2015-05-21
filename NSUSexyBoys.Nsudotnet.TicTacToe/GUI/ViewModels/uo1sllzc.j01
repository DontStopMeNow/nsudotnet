using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using Data;
using Logic;
using Condition = Data.Condition;

namespace GUI.ViewModels
{
    class MainViewModel : PropertyChangedBase
    {
        private ITicTacToeService _game;
        public Visibility Play { get; set; }
        public BindableCollection<MainFieldElementViewModel> Cells { get; set; }
        public String Winner { get; set; }
        public MainViewModel(ITicTacToeService game)
        {
            Winner = " ";
            Play = Visibility.Hidden;
            _game = game;
            Cells = new BindableCollection<MainFieldElementViewModel>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new MainFieldElementViewModel(i / 3, i % 3, Condition.FREE,this, game));
            }
        }

        public void NewGame()
        {
            Play = Visibility.Visible;
            Winner = " ";
            _game = new TicTacToeGame();
            Cells = new BindableCollection<MainFieldElementViewModel>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new MainFieldElementViewModel(i / 3, i % 3, Condition.FREE,this, _game));
            }
            NotifyOfPropertyChange(() => _game);
            NotifyOfPropertyChange(() => Cells);
            NotifyOfPropertyChange(() => Play);
            NotifyOfPropertyChange(() => Winner);
        }

        public void Refresh()
        {
            Player win = _game.GetWinner();
            if (win != null)
            {
                Play = Visibility.Hidden;
                Winner = ConditionToChar.GetChar(win.TypeLabel) + " is winner!";
                NotifyOfPropertyChange(() => Play);
                NotifyOfPropertyChange(() => Winner);
            }
        }
    }
}
