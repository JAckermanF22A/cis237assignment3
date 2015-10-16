using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numberOfLanguages;
        const decimal costPerLanguage = 250m;

        public Protocol(string Material, string Model, string Color, int NumberOfLanguages) : base(Material, Model, Color)
        {
            this.numberOfLanguages = NumberOfLanguages;
        }

        public override void CalculateTotalCost()
        {
            totalCost = (numberOfLanguages * costPerLanguage) + baseCost;
        }

        public override string ToString()
        {
            CalculateBaseCost(material);
            CalculateTotalCost();
            return this.model + " " + this.material + " " + this.color + " " + this.numberOfLanguages + " " + this.totalCost.ToString("C");  
        }
    }
}
