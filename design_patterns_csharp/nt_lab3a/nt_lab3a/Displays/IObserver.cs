using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Displays
{
    public interface IObserver
    {
        void Update(string name, int sTotal, int oTotal);
    }
}
