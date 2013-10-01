using System.Collections.Generic;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for Pizza.
    /// </summary>
    public abstract class Pizza
    {
        private string name;
        private double cost;
        protected IDough dough;
        protected ISauce sauce;
        protected List<IVeggie> veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClams clam;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public abstract string Prepare();
        public virtual string Bake() { return "Bake for 25 minutes at 350 \n"; }
        public virtual string Cut() { return "Cutting the pizza into diagonal slices \n"; }
        public virtual string Box() { return "Place pizza in official PizzaStore box \n"; }
    }
}
