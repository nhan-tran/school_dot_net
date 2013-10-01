namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Decaf.
    /// </summary>
    public class Decaf : Beverage
    {
        public override double Cost
        {
            get { return 1.05; }
        }

        public override string Description
        {
            get { return "Decaf Coffee"; }
        }
    }
}
