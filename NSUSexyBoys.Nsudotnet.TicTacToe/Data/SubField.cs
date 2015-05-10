using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class SubField
    {
        public Condition[,] Cells { get; set; }
        public Condition Condition { get; set; }
        public int FreeCells { get; set; }

        
        public SubField()
        {
            FreeCells = 9;
            Condition = Condition.FREE;
            Cells = new Condition[,] {  { Condition.FREE, Condition.FREE, Condition.FREE }, 
                                        { Condition.FREE, Condition.FREE, Condition.FREE }, 
                                        { Condition.FREE, Condition.FREE, Condition.FREE }};

        }
    }
}
