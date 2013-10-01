using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.Items;


namespace nt_lab3a.Desks
{
    public abstract class Desk : Item
    {
        private string deskStyle;
        protected List<DeskPart> parts;

        public Desk()
        {
            deskStyle = "Plain";
        }

        public string Style 
        {
            get { return deskStyle;  }
            set { deskStyle = value; }
        }


    }
}
