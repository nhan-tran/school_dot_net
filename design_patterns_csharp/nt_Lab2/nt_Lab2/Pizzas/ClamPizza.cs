using System;
using System.Text;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for ClamPizza.
    /// </summary>
    public class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            Cost = 15;
        }

        public override string Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();

            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough.ToString() + "\n");
            sb.Append(sauce.ToString() + "\n");
            sb.Append(cheese.ToString() + "\n");
            sb.Append(clam.ToString());

            return sb.ToString();
        }
    }
}
