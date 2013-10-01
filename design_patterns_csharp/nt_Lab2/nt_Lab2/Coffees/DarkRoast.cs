namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for DarkRoast.
    /// </summary>
    public class DarkRoast : Beverage
    {
        public override double Cost
        {
            get { return .99; }
        }

        public override string Description
        {
            get { return "Dark Roast Coffee"; }
        }
    }
}
