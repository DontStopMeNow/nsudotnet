using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Caliburn.Micro;
using Logic;

namespace GUI.ViewModels
{
    class MainViewModel : PropertyChangedBase
    {
        private ITicTacToeService _game;

        public MainViewModel(ITicTacToeService game)
        {
            _game = game;
        }

        public ObservableCollection<FieldElement> _mainFieldElements {get; set; }
        public ObservableCollection<FieldElement> _subFieldElements  {get; set; }

        public string _firstPlayerName  { get; set; }
        public string _secondPlayerName { get; set; }

        public int _currentPlayer { get; set; }

        /*public MainViewModel(IContainer container)
        {
            _game = container.Resolve<ITicTacToeService>();
        }*/
    }
}
