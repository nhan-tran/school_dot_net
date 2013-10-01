using System;
using System.Configuration;

namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Espresso.
    /// </summary>
    public class Espresso : Beverage
    {
        public override double Cost
        {
            get { return 1.25; }
        }

        public override string Description
        {
            get { return "Espresso"; }
        }

    }
}
