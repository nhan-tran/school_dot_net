using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Desks
{
    class SwedishDeskFactory : DeskFactory
    {

        protected override Desk BuildDesk(string type) 
        {
            Desk aDesk = null;

            switch (type)
            { 
                case "Right L":
                    aDesk = new RightLDesk();
                    aDesk.Style = "Swedish Right L Desk";
                    break;
                case "Left L":
                    aDesk = new RightLDesk();
                    aDesk.Style = "Swedish Left L Desk";
                    break;
                case "Standard":
                    aDesk = new RightLDesk();
                    aDesk.Style = "Swedish Standard Desk";
                    break;
                case "Roll Top":
                    aDesk = new RightLDesk();
                    aDesk.Style = "Swedish Roll Top Desk";
                    break;
                case "Executive":
                    aDesk = new RightLDesk();
                    aDesk.Style = "Swedish Executive Desk";
                    break;
                default:
                    //some desk, or invalid selection.
                    break;
                
            }

            return aDesk;        
        }
    }
}
