using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MainField
    {
        public SubField[,] Cells { get; set; }
    ;
        public int FreeCells { get; set; }
        public MainField()
        {
            Cells = new SubField[,] {   { new SubField(), new SubField(), new SubField() }, 
                                        { new SubField(), new SubField(), new SubField() },
                                        { new SubField(), new SubField(), new SubField() } };
        }
    }
}
