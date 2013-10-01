using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Displays
{
    class ManagerDisplay : IObserver
    {
        private double total = 0;

        public ManagerDisplay()
        {
            total = 0;
        }

        public void Update(double salesTotal, double orderTotal)
        {
            total = salesTotal;
        }

        public void Display()
        {
            Console.WriteLine("Sales Total: $" + String.Format("{0:0.00}", total));   
        }
    }
}
