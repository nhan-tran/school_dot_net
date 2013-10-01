namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Soy.
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return this.beverage.Description + ", Soy"; }
        }

        public override double Cost
        {
            get { return .15 + this.beverage.Cost; }
        }
    }
}
