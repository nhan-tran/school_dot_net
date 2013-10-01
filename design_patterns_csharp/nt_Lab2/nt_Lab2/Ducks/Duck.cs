using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    public abstract class Duck
    {
        protected string prep;
        protected ISauceThickness sauce;
        public string style { get; protected set; }
        protected double cost;

        public double Cost {get {return cost;} set{ cost = value;}}
    }
}
