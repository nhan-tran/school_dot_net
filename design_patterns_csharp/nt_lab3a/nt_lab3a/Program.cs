using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.AssemblyLines;
using nt_lab3a.Desks;
using nt_lab3a.Displays;


namespace nt_lab3a
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyLine as1 = new AssemblyLine("American1", "American");
            AssemblyLine as2 = new AssemblyLine("Swedish1", "Swedish");
            GlobalCounter theCount = GlobalCounter.Instance;
            ManagerDisplay manager = new ManagerDisplay();
            UnitDisplay unit1 = new UnitDisplay();
            UnitDisplay unit2 = new UnitDisplay();

            as1.RegisterObserver(manager);
            as1.RegisterObserver(unit1);

            as2.RegisterObserver(manager);
            as2.RegisterObserver(unit2);

            while (true)
            {
                as1.ProduceProduct();
                as2.ProduceProduct();

                Console.WriteLine();
                unit1.Display();
                unit2.Display();
                manager.Display();
            }


        }
    }
}
