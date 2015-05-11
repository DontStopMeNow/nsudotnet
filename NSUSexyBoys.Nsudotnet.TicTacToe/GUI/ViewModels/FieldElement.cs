using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ViewModels
{
    public abstract class FieldElement
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public char Value { get; set; }
        public int SizeText { get; set; }

        protected FieldElement(int row, int column, int value)
        {
            Row = row;
            Column = column;
            
            switch (value)
            {
                case 0:
                    Value = ' ';
                    break;
                case 1:
                    Value = 'x';
                    break;
                case 2:
                    Value = 'o';
                    break;
            }
        }
    }
}
