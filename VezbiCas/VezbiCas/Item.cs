
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VezbiCas
{
    public abstract class Item
    {
        public int Piece { get; set; } = 1;
        public double Discont { get; set; }
    }


}
