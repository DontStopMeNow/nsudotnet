using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    class MainFieldElement: FieldElement
    {
        public MainFieldElement(int row, int column, int value) : base(row, column, value)
        {
            SizeText = 30;
        }
    }
}
