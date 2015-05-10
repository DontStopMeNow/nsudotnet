using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class MainField
    {
        public SubField[,] Cells;

        public MainField()
        {
            Cells = new SubField[,] {   { new SubField(), new SubField(), new SubField() }, 
                                        { new SubField(), new SubField(), new SubField() },
                                        { new SubField(), new SubField(), new SubField() } };
        }
    }
}
