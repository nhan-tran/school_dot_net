namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for HouseBlend.
    /// </summary>
    public class HouseBlend : Beverage
    {
        public override double Cost
        {
            get { return .89; }
        }

        public override string Description
        {
            get { return "House Blend Coffee"; }
        }
    }
}
