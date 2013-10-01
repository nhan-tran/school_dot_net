using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Desks
{
    class ExecutiveDesk : Desk
    {
        public ExecutiveDesk()
        {
            Style = "Exectuive Desk";
            parts = new List<DeskPart> { new LeftSide(), new RightSide(), new TopSide()};

        }
    }
}
