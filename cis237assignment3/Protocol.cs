using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        //Variables
        private int numberOfLanguages;

        //Constants
        const decimal costPerLanguage = 250m;

        //Constructor, inherits from Droid base.
        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
        }

        //Methods
        public override void CalculateTotalCost()
        {
            totalCost = (numberOfLanguages * costPerLanguage) + baseCost;
        }

        public override string ToString()
        {
            CalculateBaseCost(material);
            CalculateTotalCost();
            return this.model.PadRight(10) + " | " + this.material.PadRight(8) + " | " + this.color.PadRight(5) + " | " + this.numberOfLanguages.ToString().PadRight(6) + " | ".PadRight(11)
                + " | ".PadRight(18) + " | ".PadRight(6) + " | ".PadRight(18) + " | ".PadRight(9) + " | ".PadRight(20) + " | ".PadRight(10) + " | " + this.totalCost.ToString("C");
        }
    }
}
