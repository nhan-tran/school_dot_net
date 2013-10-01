using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_Lab2.Pizzas;
using nt_Lab2.Coffees;
using nt_Lab2.Ducks;
using nt_Lab2.Displays;

namespace nt_Lab2.OrderingSystem
{
    class OrderSystem : ISubject
    {
        private volatile static OrderSystem uniqueInstance;
        private static object syncRoot = new object();
        double salesTotal;
        private List<IObserver> observers;


        public double SalesTotal
        {
            get { return salesTotal; }
            set { salesTotal = value; }
        }

        private OrderSystem()
        {
            salesTotal = 0.0;
            observers = new List<IObserver>();
        }

        public double PlaceOrder(string cType, string nyType, List<string> coffeeOrder, string duckOrder)    //an entire order
        {
            double orderTotal = 0;
            Pizza chiPizza, nyPizza;
            PizzaStore chiPizzaStore;
            PizzaStore nyPizzaStore;
            DuckOven woodOven;
            DuckOven grillOven;
            Duck delicious;


            //chicago pizza
            if (cType != "none")
            {
                chiPizzaStore = new ChicagoPizzaStore();
                chiPizza = chiPizzaStore.OrderPizza(cType);
                orderTotal += chiPizza.Cost;
            }

            //ny pizza
            if (nyType != "none")
            {
                nyPizzaStore = new NYPizzaStore();
                nyPizza = nyPizzaStore.OrderPizza(nyType);
                orderTotal += nyPizza.Cost;
            }

            //coffee
            if (coffeeOrder != null)
            {
                Beverage coffee;
                bool first = true;

                coffee = new Espresso();
                foreach (string bev in coffeeOrder)
                {
                    if (first)
                    {
                        coffee = makeBaseCoffee(bev);
                        first = false;
                    }
                    else
                    {
                        coffee = decorateCoffee(bev, coffee);
                    }                    
                }
                orderTotal += coffee.Cost;                 
            }


            //duck
            if (duckOrder == "Roasted")
            {
                woodOven = new WoodDuckOven();
                delicious = woodOven.CookDuck(duckOrder);
                orderTotal += delicious.Cost;
            }
            else if (duckOrder == "BBQ" || duckOrder == "Peking")
            {
                grillOven = new GrillDuckOven();
                delicious = grillOven.CookDuck(duckOrder);
                orderTotal += delicious.Cost;
            }
            
            salesTotal += orderTotal;       //update salesTotal
            NotifyObserver(salesTotal, orderTotal);      //notify observers
            
            return orderTotal;

        }   //end of PlaceOrder



        public void RegisterObserver(IObserver o) { this.observers.Add(o); }

        public void RemoveObserver(IObserver o)
        {
            if (this.observers.Contains(o)) this.observers.Remove(o);
        }

        public void NotifyObserver(double sTotal, double oTotal)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(sTotal, oTotal);
            }
        }


        private Beverage makeBaseCoffee(string bev)
        {
            Beverage coffee;
            switch (bev)
            {
                case "DarkRoast":
                    coffee = new DarkRoast();
                    break;
                case "Decaf":
                    coffee = new Decaf();
                    break;
                case "Espresso":
                    coffee = new Espresso();
                    break;
                case "HouseBlend":
                    coffee = new HouseBlend();
                    break;
                default:                //invalid base
                    coffee = null;
                    break;
            }
            return coffee;
        }

        private Beverage decorateCoffee(string bev, Beverage coffee)
        {
            Beverage c; 
                switch (bev)
                {
                    case "Mocha":
                        c = new Mocha(coffee);
                        break;
                    case "Soy":
                        c = new Soy(coffee);
                        break;
                    case "SteamedMilk":
                        c = new SteamedMilk(coffee);
                        break;
                    case "WhipCream":
                        c = new Whip(coffee);
                        break;
                    default:
                        c = null;
                        break;
                }
           
            return c;
        }
            
       


        public static OrderSystem Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new OrderSystem();
                        }
                    }
                }

                return uniqueInstance;
            }
        }

    }
}
