using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.Items;

namespace nt_lab3a.Accessories
{
    public abstract class Accessory : Item
    {
        protected string Manufacturer { get; set; }
        protected Item baseDesk;
        public IStyle Style { get; set; }
    }
}
