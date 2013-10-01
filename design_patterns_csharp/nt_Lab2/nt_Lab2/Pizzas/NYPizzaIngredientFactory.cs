using System;
using System.Collections.Generic;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for NYPizzaIngredientFactory.
    /// </summary>
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() { return new ThinCrustDough(); }
        public ISauce CreateSauce() { return new MarinaraSauce(); }
        public ICheese CreateCheese() { return new ReggianoCheese(); }

        public List<IVeggie> CreateVeggie()
        {
            List<IVeggie> veggies = new List<IVeggie> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public IPepperoni CreatePepperoni() { return new SlicedPepperoni(); }
        public IClams CreateClam() { return new FreshClams(); }
    }
}
