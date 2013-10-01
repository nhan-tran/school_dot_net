using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Displays
{
    class CashierDisplay : IObserver
    {
        private double total;

        public CashierDisplay()
        {
            total = 0;
        }

        public void Update(double salesTotal, double orderTotal)
        {
            total = orderTotal;
        }

        public void Display()
        {
            Console.WriteLine("Order Total: $" + String.Format("{0:0.00}", total));
        }
    }
}
