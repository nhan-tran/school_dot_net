using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_Lab2.Displays
{
    public interface IObserver
    {
        void Update(double sTotal, double oTotal);
    }
}