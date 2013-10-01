using System;
using System.Text;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for CheesePizza.
    /// </summary>
    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            Cost = 10;
        }

        public override string Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough.ToString() + "\n");
            sb.Append(sauce.ToString() + "\n");
            sb.Append(cheese.ToString());

            return sb.ToString();
        }
    }
}
