using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.Items;
using nt_lab3a.Desks;

namespace nt_lab3a.Accessories
{
    public class AccessoryFactory
    {
        public AccessoryFactory()
        { }

        public Item Decorate(Item aDesk, string aType, IStyle sType)
        {
            Item desk;

            desk = null;
            switch (aType)
            { 
                case "SH":
                    desk = new Shelf(aDesk, sType);
                    break;
                case "TR":
                    desk = new Tray(aDesk, sType);
                    break;
                case "DR":
                    desk = new Drawer(aDesk, sType);
                    break;
                case "CC":
                    desk = new CornerCover(aDesk, sType);
                    break;
                case "MS":
                    desk = new MonitorStand(aDesk, sType);
                    break;
            }

            return desk;
        }

    }
}
