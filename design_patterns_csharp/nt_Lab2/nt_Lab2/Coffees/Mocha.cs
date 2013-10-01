using System;
using System.Configuration;

namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Mocha.
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost
        {
            get { return 0.75 + this.beverage.Cost; }
        }

        public override string Description
        {
            get { return beverage.Description + ", Mocha"; }
        }
    }
}
