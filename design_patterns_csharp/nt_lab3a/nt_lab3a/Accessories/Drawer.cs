using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.Items;

namespace nt_lab3a.Accessories
{
    class Drawer : Accessory
    {
        public Drawer(Item desk, IStyle style)
        {
            baseDesk = desk;
            Style = style;
        }
    }
}
