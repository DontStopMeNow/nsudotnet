﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MainField
    {
        public SubField[,] Cells { get; set; }
        public Condition Condition { get; set; }
        public int FreeCells { get; set; }
        public MainField()
        {
            Condition = Condition.FREE;
            FreeCells = 9;
            Cells = new SubField[,] {   { new SubField(), new SubField(), new SubField() }, 
                                        { new SubField(), new SubField(), new SubField() },
                                        { new SubField(), new SubField(), new SubField() } };
        }
    }
}
