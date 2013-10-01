using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    public abstract class DuckOven
    {
        public Duck CookDuck(string style)
        {
            Duck aDuck;

            aDuck = PrepareDuck(style);

            return aDuck;
        }

        protected abstract Duck PrepareDuck(string style);
    }
}
