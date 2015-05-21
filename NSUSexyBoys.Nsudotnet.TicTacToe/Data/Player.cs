using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Player
    {
        public String Name { get; set; }
        public int Wins { get; set; }
        public Condition TypeLabel { get; set; }

        public Player(string name, Condition lbl)
        {
            Name = name;
            TypeLabel = lbl;
        }
    }
}
