using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    class GrillDuckOven : DuckOven
    {
        protected override Duck PrepareDuck(string style)
        {
            if (style.Equals("BBQ")) return new BBQDuck();
            else if (style.Equals("Peking")) return new PekingDuck();
            else return null;
        }
    }
}
