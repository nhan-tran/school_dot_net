using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Ducks
{
    public class BBQDuck : Duck
    {
        public BBQDuck()
        {
            prep = "BBQ";
            sauce = new MediumSauce(); ;
            cost = 9.00;
        }
    }
}
