using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid : IDroid
    {
        //Variables
        protected string material;
        protected string model;
        protected string color;
        protected decimal baseCost;
        protected decimal totalCost;

        //Constructor
        public Droid(string Material, string Model, string Color)
        {
            this.material = Material;
            this.model = Model;
            this.color = Color;
        }

        //Methods
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public void CalculateBaseCost(string droidMaterial)
        {
            switch (droidMaterial)
            {
                case "titanium":
                    baseCost = 999.99m;
                    break;
                case "steel":
                    baseCost = 199.99m;
                    break;
                case "iron":
                    baseCost = 2499.99m;
                    break;
            }
        }

        public virtual void CalculateTotalCost()
        {
            totalCost = baseCost;
        }

        public override string ToString()
        {
            CalculateBaseCost(material);
            CalculateTotalCost();
            return this.model + " " + this.material + " " + this.color + " " + this.totalCost.ToString("C");   
        }
    }
}
