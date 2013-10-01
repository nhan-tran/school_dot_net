using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nt_lab3a.Desks;
using nt_lab3a.Items;
using nt_lab3a.Accessories;
using nt_lab3a.Displays;

namespace nt_lab3a.AssemblyLines
{
    class AssemblyLine : ISubject
    {
        public int localCount;
        public string Name { get; set; }
        GlobalCounter TotalCount = GlobalCounter.Instance;
        DeskFactory factory;
        List<IObserver> observers;

        public AssemblyLine(string name, string ProductType)
        {
            Name = name;
            observers = new List<IObserver>();

            if (ProductType.Equals("American"))
            {
                factory = new AmericanDeskFactory();
            } 
            else if (ProductType.Equals("Swedish"))
            {
                factory = new SwedishDeskFactory();
            }
        }

        public void ProduceProduct()
        {
            Item desk;
            string deskType;

            deskType = GetDeskType();
            desk = factory.MakeDesk(deskType);
            
            //decorate with accessories
            string addFlg;
            Console.WriteLine("Add accessories? (Y/N) ");
            addFlg = Console.ReadLine();

            while (addFlg.Equals("Y") || addFlg.Equals("y"))
            {
                desk = AddAccessories(desk);
                Console.WriteLine("Add more accessories? (Y/N) ");
                addFlg = Console.ReadLine();
            }


            localCount++;
            TotalCount.Total++;
            NotifyObserver(Name, localCount, TotalCount.Total);
  
        }

        public string GetDeskType()
        {
            string type = "";
            Boolean flg = false;

            while (!flg)
            {
                Console.WriteLine("\n" + Name + ": What type of desk? (RL, LL, ST, RT, EX) ");
                type = Console.ReadLine();
                switch(type)
                {
                    case "RL":
                        type = "Right L";
                        flg = true;
                        break;
                    case "LL":
                        type = "Left L";
                        flg = true;
                        break;
                    case "ST":
                        type = "Standard";
                        flg = true;
                        break;
                    case "RT":
                        type = "Roll Top";
                        flg = true;
                        break;
                    case "EX":
                        type = "Executive";
                        flg = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection, try again.\n");
                        break;
                }           
            }
            return type;
        }

        Item AddAccessories(Item desk)
        {
            string aSelection;
            IStyle sSelection;
            AccessoryFactory aFactory;

            aSelection = GetAccessory();
            sSelection = GetStyle();

            aFactory = new AccessoryFactory();

            desk = aFactory.Decorate(desk, aSelection, sSelection);

            return desk;
        }

        public IStyle GetStyle()
        { 
            string selection;
            IStyle aStyle;
            Boolean validChoice = false;

            aStyle = null;

            while (!validChoice)
            {
                Console.WriteLine("Select aStyle (70s, 80s, 90s, MOD, FUT): ");
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "70s":
                        aStyle = new Style_1970s();
                        validChoice = true;
                        break;
                    case "80s":
                        aStyle = new Style_1980s();
                        validChoice = true;
                        break;
                    case "90s":
                        aStyle = new Style_1990s();
                        validChoice = true;
                        break;
                    case "MOD":
                        aStyle = new Style_Modern();
                        validChoice = true;
                        break;
                    case "FUT":
                        aStyle = new Style_Futuristic();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid aStyle selection, try again.\n");                    
                        break;
                }
            }
            return aStyle;    
        }

        string GetAccessory()
        {
            string selection;
            Boolean validChoice = false;

            Console.WriteLine("Select accessory to add (SH, TR, MS, CC, DR): ");
            selection = Console.ReadLine();
            
            while (!validChoice)
            {
                switch (selection)
                {
                    case "SH":
                        validChoice = true;
                        break;
                    case "TR":
                        validChoice = true;
                        break;
                    case "MS":
                        validChoice = true;
                        break;
                    case "CC":
                        validChoice = true;
                        break;
                    case "DR":
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Invalid accessory choice, try again.\n");
                        Console.WriteLine("Select accessory to add (SH, TR, MS, CC, DR): ");
                        selection = Console.ReadLine();
                        break;
                }
            }
            return selection;        
        }


        public void RegisterObserver(IObserver o) { this.observers.Add(o); }

        public void RemoveObserver(IObserver o)
        {
            if (this.observers.Contains(o)) this.observers.Remove(o);
        }

        public void NotifyObserver(string name, int localCount, int totalCount)
        {
            foreach (IObserver observer in this.observers)
            {
                observer.Update(Name, localCount, totalCount);
            }
        }

    }   //end class
}
