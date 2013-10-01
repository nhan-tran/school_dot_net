using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Desks
{
    class AmericanDeskFactory : DeskFactory
    {

        protected override Desk BuildDesk(string type) 
        {
            Desk aDesk = null;

            switch (type)
            { 
                case "Right L":
                    aDesk = new RightLDesk();
                    aDesk.Style = "American Right L Desk";
                    break;
                case "Left L":
                    aDesk = new LeftLDesk();
                    aDesk.Style = "American Left L Desk";
                    break;
                case "Standard":
                    aDesk = new StandardDesk();
                    aDesk.Style = "American Standard Desk";
                    break;
                case "Roll Top":
                    aDesk = new RollTopDesk();
                    aDesk.Style = "American Roll Top Desk";
                    break;
                case "Executive":
                    aDesk = new ExecutiveDesk();
                    aDesk.Style = "American Executive Desk";
                    break;
                default:
                    //some desk, or invalid selection.
                    break;
              }

            return aDesk;        
        }
    }
}
