using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Desks
{
    public abstract class DeskFactory
    {
        //make the desk
        public Desk MakeDesk(string type)
        {
            Desk aDesk;

            aDesk = BuildDesk(type);

            return aDesk;
        }

        protected abstract Desk BuildDesk(string type);
    }
}
