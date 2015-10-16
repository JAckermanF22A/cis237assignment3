using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        //Variables
        protected bool toolBox;
        protected bool computerConnection;
        protected bool arm;
        protected const decimal toolCost = 74.99m;
        protected const decimal compConnectionCost = 25.00m;
        //private const string armCost = "a leg"
        protected const decimal armCost = 2499.99m;

        //Constructor
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm) : base(Material, Model, Color)
        {
            this.toolBox = ToolBox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }

        public override void CalculateTotalCost()
        {
            totalCost = baseCost;

            if(toolBox == true)
            {
                totalCost = totalCost + toolCost;
            }
            if(computerConnection == true)
            {
                totalCost += compConnectionCost;
            }
            if(arm == true)
            {
                totalCost += armCost;
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

            return tempString;
        }
    }
}
