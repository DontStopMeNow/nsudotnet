using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using Data;

namespace GUI.ViewModels
{
    class MainFieldElement: FieldElementViewModel
    {
        public BindableCollection<SubFieldElementViewModel> Cells { get; set; }
        public MainFieldElement(int row, int column, Condition value) : base(row, column, value)
        {
            Cells = new BindableCollection<SubFieldElementViewModel>();
            for (var i = 0; i < 9; i++)
            {
                Cells.Add(new SubFieldElementViewModel(i/3, i%3, Condition.CROSS));
            }
            SizeText = 50;
        }
    }
}
