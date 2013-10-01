using System.Collections.Generic;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for IPizzaIngredientFactory.
    /// </summary>
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ISauce CreateSauce();
        ICheese CreateCheese();
        List<IVeggie> CreateVeggie();
        IPepperoni CreatePepperoni();
        IClams CreateClam();
    }
}
