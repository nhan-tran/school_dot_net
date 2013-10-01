using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_Lab2.OrderingSystem;
using nt_Lab2.Displays;

namespace nt_Lab2
{
    class Program
    {

        static void Main(string[] args)
        {
            OrderSystem o = OrderSystem.Instance;
            List<string> coffeeOrder = new List<string>();  //a coffee beverage
            string chiPizza;
            string nyPizza;
            string duckType;
            CashierDisplay front = new CashierDisplay();
            ManagerDisplay back = new ManagerDisplay();

            //register observers
            o.RegisterObserver(front);
            o.RegisterObserver(back);

            //initial salesTotal is 0
            Console.WriteLine("Staring Total: $" + String.Format("{0:0.00}", o.SalesTotal));
            Console.WriteLine('\n');

            //order 1
            coffeeOrder.Clear();
            coffeeOrder = CoffeeName("Espresso Soy Mocha WhipCream");
            chiPizza = "cheese";
            nyPizza = "clam";
            duckType = "Roasted";
            o.PlaceOrder(chiPizza, nyPizza, coffeeOrder, duckType);
            front.Display();
            back.Display();
            Console.WriteLine('\n');


            //order 2
            coffeeOrder.Clear();
            coffeeOrder = CoffeeName("HouseBlend Soy Mocha WhipCream");
            chiPizza = "clam";
            nyPizza = "pepperoni";
            duckType = "Peking";
            o.PlaceOrder(chiPizza, nyPizza, coffeeOrder, duckType);
            front.Display();
            back.Display();
            Console.WriteLine('\n');


            //order 3
            coffeeOrder.Clear();
            coffeeOrder = CoffeeName("Decaf SteamedMilk WhipCream");
            chiPizza = "none";
            nyPizza = "cheese";
            duckType = "BBQ";
            o.PlaceOrder(chiPizza, nyPizza, coffeeOrder, duckType);
            front.Display();
            back.Display();
            Console.WriteLine('\n');

            Console.ReadLine();     //end main
        }

        static List<string> CoffeeName(string c)
        {
            List<string> name = new List<string>();

            string[] text = c.Split(' ');

            foreach (string s in text)
            {
                name.Add(s);
            }

            return name;
        }

    }
}
