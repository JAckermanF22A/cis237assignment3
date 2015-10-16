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
            tempString = this.model + " " + this.material + " " + this.color;

            if (toolBox == true)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }
            if (computerConnection == true)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }
            if (arm == true)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }
            if(trashCompactor)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }
            if(vacuum)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }

            return tempString;
        }
    }
}
