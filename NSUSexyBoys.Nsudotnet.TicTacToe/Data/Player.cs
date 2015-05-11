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
        public Condition TypeLabel {
            get { return TypeLabel; }
            set {
                if (value == Condition.CROSS || value == Condition.ZERO)
                {
                    this.TypeLabel = value;
                }
                else
                {
                    throw new Exception("Incorrect lable for player.");
                }
            }
        }

        public Player(string name, Condition lbl)
        {
            Name = name;
            TypeLabel = lbl;
        }
    }
}
