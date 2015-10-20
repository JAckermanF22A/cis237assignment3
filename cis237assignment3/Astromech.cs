using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        //Variables
        private bool fireExtinguisher;
        private int numberShips;

        //Constants
        private const decimal costPerShip = 129.99m;
        private const decimal fireExtinguisherCost = 49.99m;

        //Constructor, inherits from Utility base.
        public Astromech(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm, bool FireExtinguisher, int NumberShips) : base(Material, Model, Color, ToolBox, ComputerConnection, Arm)
        {
            this.fireExtinguisher = FireExtinguisher;
            this.numberShips = NumberShips;
        }

        //Methods
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

            tempString += " | ".PadRight(18) + " | ".PadRight(9);

            if(fireExtinguisher == true)
            {
                tempString += " | " + "Y".PadRight(17);
            }
            else
            {
                tempString += " | " + "N";
            }

            tempString += " | " + numberShips.ToString().PadRight(7) + " | " + this.totalCost.ToString("C");
            return tempString;
        }
    }
}
