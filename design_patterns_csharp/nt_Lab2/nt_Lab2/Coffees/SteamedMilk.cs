namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for SteamedMilk.
    /// </summary>
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return this.beverage.Description + ", Steamed Milk"; }
        }

        public override double Cost
        {
            get { return .10 + this.beverage.Cost; }
        }
    }
}
