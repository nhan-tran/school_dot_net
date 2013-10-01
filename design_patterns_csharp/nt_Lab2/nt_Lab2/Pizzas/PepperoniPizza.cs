using System.Text;

namespace nt_Lab2.Pizzas
{
    /// <summary>
    /// Summary description for PepperoniPizza.
    /// </summary>
    public class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
            Cost = 13;
        }

        public override string Prepare()
        {
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            pepperoni = ingredientFactory.CreatePepperoni();

            StringBuilder sb = new StringBuilder();
            sb.Append("Preparing " + Name + "\n");
            sb.Append(dough.ToString() + "\n");
            sb.Append(sauce.ToString() + "\n");
            sb.Append(cheese.ToString() + "\n");
            sb.Append(pepperoni.ToString());

            return sb.ToString();
        }
    }
}
