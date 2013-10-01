namespace nt_Lab2.Coffees
{
    /// <summary>
    /// Summary description for Beverage.
    /// </summary>
    public abstract class Beverage
    {
        public virtual string Description { get { return "Unknown Beverage"; } }

        public BeverageSize Size { get; set; }

        public abstract double Cost { get; }
    }
}
