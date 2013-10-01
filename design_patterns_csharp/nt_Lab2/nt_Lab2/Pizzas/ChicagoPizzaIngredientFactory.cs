using System;
using System.Collections.Generic;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for ChicagoPizzaIngredientFactory.
    /// </summary>
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() { return new ThickCrustDough(); }
        public ISauce CreateSauce() { return new PlumTomatoSauce(); }
        public ICheese CreateCheese() { return new Mozzerella(); }

        public List<IVeggie> CreateVeggie()
        {
            List<IVeggie> veggies = new List<IVeggie> { new BlackOlives(), new Spinach(), new EggPlant() };
            return veggies;
        }

        public IPepperoni CreatePepperoni() { return new SlicedPepperoni(); }
        public IClams CreateClam() { return new FrozenClams(); }
    }
}
