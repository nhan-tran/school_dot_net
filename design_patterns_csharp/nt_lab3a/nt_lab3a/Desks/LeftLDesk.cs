using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Desks
{
    public class LeftLDesk : Desk
    {
        public LeftLDesk()
        {
            Style = "Left L Desk";
            parts =  new List<DeskPart>{new LeftSide(), new RightSide(), new TopSide(), new LeftSideExtension()};
        }
    }
}
