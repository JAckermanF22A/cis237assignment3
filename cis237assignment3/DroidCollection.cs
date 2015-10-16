using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        public string model;
        private string material;
        private string color;

        public IDroid[] droidArray;
        private int counter;

        public DroidCollection()
        {
            droidArray = new IDroid[20];
            counter = 0;

        }

        public void AddProtocol(string Model, string Material, string Color, int NumberOfLanguages)
        {
            droidArray[counter] = new Protocol(Material, Model, Color, NumberOfLanguages);
            counter++;
        }

        public void AddUtility(string Model, string Material, string Color, bool ToolBox, bool ComputerConnection, bool Arm)
        {
            droidArray[counter] = new Utility(Material, Model, Color, ToolBox, ComputerConnection, Arm);
            counter++;
        }

        public void AddJanitor(string Model, string Material, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum)
        {
            droidArray[counter] = new Janitor(Material, Model, Color, ToolBox, ComputerConnection, Arm, TrashCompactor, Vacuum);
        }

        public void AddAstromech(string Model, string Material, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips)
        {
            droidArray[counter] = new Astromech(Material, Model, Color, ToolBox, ComputerConnection, Arm, FireExtinguisher, NumberShips);
        }
    }
}
