using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    class PekingDuck : Duck
    {
        public PekingDuck()
        {
            prep = "Bought from store";
            sauce = new HeavySauce();
            cost = 10.00;
        }
    }
}
