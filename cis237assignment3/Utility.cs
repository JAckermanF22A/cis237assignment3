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
        
        //Constants
        protected const decimal toolCost = 74.99m;
        protected const decimal compConnectionCost = 25.00m;
        //private const string armCost = "a leg"
        protected const decimal armCost = 2499.99m;

        //Constructor, inherits from Droid base
        public Utility(string Material, string Model, string Color, bool ToolBox, bool ComputerConnection, bool Arm) : base(Material, Model, Color)
        {
            this.toolBox = ToolBox;
            this.computerConnection = ComputerConnection;
            this.arm = Arm;
        }

        //Methods
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

            tempString += " | ".PadRight(18) + " | ".PadRight(9) + " | ".PadRight(20) + " | ".PadRight(10) + " | " + this.totalCost.ToString("C");

            return tempString;
        }
    }
}
