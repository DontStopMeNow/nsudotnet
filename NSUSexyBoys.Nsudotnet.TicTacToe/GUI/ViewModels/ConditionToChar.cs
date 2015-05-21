using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace GUI.ViewModels
{
    static class ConditionToChar
    {
        public static char GetChar(Condition value)
        {
            var res = ' ';
            switch (value)
            {
                case Condition.FREE:
                    res = ' ';
                    break;
                case Condition.CROSS:
                    res = 'x';
                    break;
                case Condition.ZERO:
                    res = 'o';
                    break;
            }
            return res;
        }
    }

}
