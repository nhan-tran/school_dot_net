using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nt_lab3a
{
    /// <summary>
    /// Implementation of a singleton
    /// This class represents the count of desks made by every assembly line
    /// </summary>
    class GlobalCounter
    {
        private volatile static GlobalCounter uniqueInstance;
        private static object syncRoot = new object();
        private int totalDesks;

        private GlobalCounter()
        {
            totalDesks = 0;
    
        }

        //property to get totalDesks
        public int Total
        {
            get { return uniqueInstance.totalDesks; }
            set { uniqueInstance.totalDesks = value; }
        }



        //thread safe initialization of a single instance of this GlobalCounter
        public static GlobalCounter Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (uniqueInstance == null)
                        {
                            uniqueInstance = new GlobalCounter();
                        }
                    }
                }

                return uniqueInstance;
            }
        }
    
    
    }
}
