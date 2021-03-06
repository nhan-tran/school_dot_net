﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a.Displays
{
    class ManagerDisplay : IObserver
    {
        public int UnitCount { set; get; }
        public int GlobalCount { set; get; }
        public string UnitName { get; set; }

        public ManagerDisplay()
        {
            UnitCount = 0;
            GlobalCount = 0;
            UnitName = "Unassigned";
        }

        public void Update(string name, int unit, int global)
        {
            UnitCount = unit;
            GlobalCount = global;
            UnitName = name;
        }

        public void Display()
        {
            //Console.WriteLine("Desk count for " + UnitName + ": " + UnitCount);
            Console.WriteLine("Desk count for all assembly lines: " + GlobalCount);
        }
    }
}
