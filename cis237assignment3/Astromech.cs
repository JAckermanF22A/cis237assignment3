using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private bool fireExtinguisher;
        private int numberShips;

        const decimal costPerShip = 129.99m;
        private decimal fireExtinguisherCost = 49.99m;

        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips) : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost;
            totalCost += numberShips * costPerShip;

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
            if(fireExtinguisher == true)
            {
                totalCost += fireExtinguisherCost;
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
            if(fireExtinguisher == true)
            {
                tempString += " " + "Y";
            }
            else
            {
                tempString += " " + "N";
            }

            tempString += " " + numberShips;
            return tempString;
        }
    }
}
