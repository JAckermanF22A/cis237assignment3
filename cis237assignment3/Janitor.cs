using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private bool trashCompactor;
        private bool vacuum;

        private decimal compactorCost = 174.99m;
        private decimal vacuumCost = 24.99m;

        public Janitor(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool TrashCompactor, bool Vacuum) : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.trashCompactor = TrashCompactor;
            this.vacuum = Vacuum;
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost;

            if (toolBox == true)
            {
                totalCost = totalCost + toolCost;
            }
            if (computerConnection == true)
            {
                totalCost += compConnectionCost;
            }
            if (arm == true)
            {
                totalCost += armCost;
            }
            if(trashCompactor == true)
            {
                totalCost += compactorCost;
            }
            if(vacuum == true)
            {
                totalCost += vacuumCost;
            }
        }

        public override string ToString()
        {
            CalculateBaseCost(material);
            CalculateTotalCost();

            string tempString;
            tempString = this.model.PadRight(10) + " | " + this.material.PadRight(8) + " | " + this.color.PadRight(5);

            tempString += " | ".PadRight(9);

            if (toolBox == true)
            {
                tempString += " | " + "Y".PadRight(8);
            }
            else
            {
                tempString += " | " + "N".PadRight(8);
            }

            if (computerConnection == true)
            {
                tempString += " | " + "Y".PadRight(15);
            }
            else
            {
                tempString += " | " + "N".PadRight(15);
            }
            if (arm == true)
            {
                tempString += " | " + "Y".PadRight(3);
            }
            else
            {
                tempString += " | " + "N".PadRight(3);
            }
            if(trashCompactor)
            {
                tempString += " | " + "Y".PadRight(15);
            }
            else
            {
                tempString += " | " + "N".PadRight(15);
            }
            if(vacuum)
            {
                tempString += " | " + "Y".PadRight(6);
            }
            else
            {
                tempString += " | " + "N".PadRight(6);
            }

            tempString += " | ".PadRight(20) + " | ".PadRight(10) + " | " + this.totalCost.ToString("C");

            return tempString;
        }
    }
}
