using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    public class RoastedDuck : Duck
    {
        public RoastedDuck()
        {
            prep = "Roasted";
            sauce = new ThinSauce();
            cost = 8.50;
        }
    }
}
