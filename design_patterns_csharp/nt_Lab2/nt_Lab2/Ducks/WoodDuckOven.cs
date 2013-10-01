using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    class WoodDuckOven : DuckOven
    {
        protected override Duck PrepareDuck(string style)
        {
            if (style.Equals("Roasted")) return new RoastedDuck();
            else return null;
        }
    }
}
