namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Whip.
    /// </summary>
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return this.beverage.Description + ", Whip"; }
        }

        public override double Cost
        {
            get { return .10 + this.beverage.Cost; }
        }
    }
}
